import { NgModule, ModuleWithProviders } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

import { SharedModule } from './../shared/shared.module';
import { ComicListComponent} from './comic-list/comic-list.component';

const comicsRouting: ModuleWithProviders = RouterModule.forChild([
  {
    path: '',
    component: ComicListComponent
  }
]);

@NgModule({
  imports: [
    comicsRouting,
    CommonModule,
    SharedModule
  ],
  declarations: [
    ComicListComponent
  ],
  providers : []
})

export class ComicsModule { }
