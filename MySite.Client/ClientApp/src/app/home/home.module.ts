import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MottoComponent } from './motto/motto.component';
import { HomepageComponent } from './homepage/homepage.component';
import { LogoComponent } from './logo/logo.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule
  ],
  declarations: [MottoComponent, HomepageComponent, LogoComponent],
  exports: [HomepageComponent]
})
export class HomeModule { }
