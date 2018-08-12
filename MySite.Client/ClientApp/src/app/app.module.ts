import { HomepageModule } from './homepage/homepage.module';
import { HomeComponent } from './homepage/home/home.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'about', component: HomeComponent },
  { path: '**', redirectTo: '/home' }
];

@NgModule({
  imports: [BrowserModule, HomepageModule, RouterModule.forRoot(routes)],
  declarations: [AppComponent],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
