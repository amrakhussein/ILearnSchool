import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'home'
},
{
  path: 'home',
  loadComponent: () =>
    import('./home/home.component').then(
      (x) => x.HomeComponent
    ),
},
  {
    path: 'register',
    loadComponent: () =>
      import('./authentication/register/register.component').then(
        (x) => x.RegisterComponent
      ),
  },
  {
    path: 'login',
    loadComponent: () =>
      import('./authentication/login/login.component').then(
        (x) => x.LoginComponent
      ),
  },
  {
    path: 'instructors',
    loadComponent: () =>
      import('./instructors/instructors.component').then(
        (x) => x.InstructorsComponent
      ),
  },
  {
    path: 'departments',
    loadComponent: () =>
      import('./departments/departments.component').then(
        (x) => x.DepartmentsComponent
      ),
  },
  {
    path: 'home',
    loadComponent: () =>
      import('./home/home.component').then(
        (x) => x.HomeComponent
      ),
  },
  // {
  //   path: '**',
  //   loadComponent: () => import('./page-not-found/page-not-found.component')
  //     .then(mod => mod.PageNotFoundComponent)
  // }
  
];
