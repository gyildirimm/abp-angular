import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/brand-store',
        name: '::Menu:BrandStore',
        iconClass: 'fas fa-book',
        order: 2,
        layout: eLayoutType.application,
        requiredPolicy: 'Brand.Request'
      },
      {
        path: '/brands',
        name: '::Menu:Brands',
        parentName: '::Menu:BrandStore',
        layout: eLayoutType.application,
        requiredPolicy: 'Brand.Request'
      },
      {
        path: '/model-store',
        name: '::Menu:ModelStore',
        iconClass: 'fas fa-book',
        order: 3,
        layout: eLayoutType.application,
        requiredPolicy: 'Model.Request'
      },
      {
        path: '/models',
        name: '::Menu:Models',
        parentName: '::Menu:ModelStore',
        layout: eLayoutType.application,
        requiredPolicy: 'Model.Request'
      },{
        path: '/car-store',
        name: '::Menu:CarStore',
        iconClass: 'fas fa-book',
        order: 3,
        layout: eLayoutType.application,
        requiredPolicy: 'Car.Request'
      },
      {
        path: '/cars',
        name: '::Menu:Cars',
        parentName: '::Menu:CarStore',
        layout: eLayoutType.application,
        requiredPolicy: 'Car.Request'
      },
    ]);
  };
}
