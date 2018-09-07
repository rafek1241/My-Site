import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ContactComponent } from "./contact/contact.component";
import { ContactFormComponent } from "./contact-form/contact-form.component";
import { ContactDescrComponent } from "./contact-descr/contact-descr.component";
import { FontAwesomeModule } from "../../../node_modules/@fortawesome/angular-fontawesome";
import { library } from "@fortawesome/fontawesome-svg-core";
import { FormsModule } from "../../../node_modules/@angular/forms";
import { AchievementsComponent } from "./achievements/achievements.component";
import { fas } from "@fortawesome/free-solid-svg-icons";

library.add(fas);

@NgModule({
  imports: [CommonModule, FontAwesomeModule, FormsModule],
  declarations: [
    ContactComponent,
    ContactFormComponent,
    ContactDescrComponent,
    AchievementsComponent
  ]
})
export class ContactModule {}
