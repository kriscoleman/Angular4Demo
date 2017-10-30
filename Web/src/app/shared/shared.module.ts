import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [
    CommonModule
],
exports: [
    CommonModule,
    HeaderComponent,
    FooterComponent
],
declarations: [
    HeaderComponent,
    FooterComponent
]
})
export class SharedModule { }
