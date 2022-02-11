import { NgModule } from '@angular/core';

import { ModelRoutingModule } from './model-routing.module';
import { ModelComponent } from './model.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    ModelComponent
  ],
  imports: [
    SharedModule,
    ModelRoutingModule
  ]
})
export class ModelModule { }
