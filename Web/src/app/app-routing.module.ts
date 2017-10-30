import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

export const routes: Routes = [
  // Point router to modules for lazy loading
  { path: '', loadChildren: './home/home.module#HomeModule' },
  { path: 'comics', loadChildren: './comics/comics.module#ComicsModule'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)], // * Never call forRoot in a feature routing module
  exports: [RouterModule]
})

export class AppRoutingModule {}
