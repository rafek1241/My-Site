import { environment } from "./../environments/environment";
import { ContactComponent } from "./contact/contact/contact.component";
import { AboutComponent } from "./about/about/about.component";
import { HomepageModule } from "./homepage/homepage.module";
import { HomeComponent } from "./homepage/home/home.component";
import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { FontAwesomeModule } from "@fortawesome/angular-fontawesome";

import { AppComponent } from "./app.component";
import { AboutModule } from "./about/about.module";
import { ContactModule } from "./contact/contact.module";
import { ApiModule } from "./api/api.module";

const routes: Routes = [
  { path: "", redirectTo: "/home", pathMatch: "full" },
  { path: "home", component: HomeComponent },
  { path: "about", component: AboutComponent },
  { path: "contact", component: ContactComponent },
  { path: "**", redirectTo: "/home" }
];

@NgModule({
  imports: [
    ApiModule,
    BrowserModule,
    HomepageModule,
    AboutModule,
    ContactModule,
    RouterModule.forRoot(routes),
    FontAwesomeModule
  ],
  declarations: [AppComponent],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
