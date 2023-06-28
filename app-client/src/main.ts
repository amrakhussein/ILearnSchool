import { ErrorHandler, importProvidersFrom } from '@angular/core';
import { BrowserModule, bootstrapApplication } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { routes } from './app/app-routing.module';
import { AppComponent } from './app/app.component';

import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { provideAnimations } from '@angular/platform-browser/animations';
import { CustomErrorHandlerService } from './app/errors/custom-error-handler.service';
import { GlobalHttpErrorHandlerInterceptor } from './app/interceptors/global-http-error-handler.interceptor';
import { JwtInterceptor } from './app/interceptors/jwt.interceptor';

// TODO::
//   enableProdMode();

bootstrapApplication(AppComponent, {
  providers: [
    { provide: ErrorHandler, useClass: CustomErrorHandlerService },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: GlobalHttpErrorHandlerInterceptor,
      multi: true,
    },
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    importProvidersFrom([RouterModule.forRoot(routes), BrowserModule]),
    provideAnimations(),
  ],
}).catch((err) => console.error(err));
