import { HomeComponent } from './home.component';
import { SharedModule } from './../shared/shared.module';
import { NgModule, ModuleWithProviders } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

const homeRouting: ModuleWithProviders = RouterModule.forChild([
  {
    path: '',
    component: HomeComponent
  }
]);

@NgModule({
  imports: [
    homeRouting,
    CommonModule,
    SharedModule
  ],
  declarations: [
    HomeComponent
  ],
  providers : []
})
export class HomeModule { }
