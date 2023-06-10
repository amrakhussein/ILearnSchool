using IlearnSchool.Api;

using ILearnSchool.Core;
using ILearnSchool.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    // Register Core, Infrastructure & Persistence Layers
    builder.Services
        .AddPresentation()
        .AddCore()
        .AddInfrastructure(builder.Configuration)
        .AddPersistence(builder.Configuration);
}


var app = builder.Build();

// Configure the HTTP request pipeline.
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseExceptionHandler(errorHandlingPath: "/error");
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
