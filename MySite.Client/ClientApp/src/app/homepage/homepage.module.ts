import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { LogoComponent } from './logo/logo.component';
import { MottoComponent } from './motto/motto.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [HomeComponent, LogoComponent, MottoComponent]
})
export class HomepageModule { }
