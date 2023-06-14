using ErrorOr;

using FluentValidation;

using MediatR;

namespace ILearnSchool.Core.Helper;

public class GenericValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : IErrorOr
{
    private readonly IValidator<TRequest>? _validator;

    public GenericValidationBehavior(IValidator<TRequest>? validator = null)
    {
        _validator = validator;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validator is null)
            return await next();

        var validationResults = await _validator.ValidateAsync(request, cancellationToken);

        if (validationResults.IsValid)
            return await next();


        var errors = validationResults.Errors
            .Select(f => Error.Validation(f.PropertyName, f.ErrorMessage))
            .ToList();


        // Try converting errors into ErrorOr type; If failed, then it will be handled by exception handler middleware
        return (dynamic)errors;
    }
}
