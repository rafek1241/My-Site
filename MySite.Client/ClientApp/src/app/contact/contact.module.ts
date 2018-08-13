import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContactComponent } from './contact/contact.component';
import { ContactFormComponent } from './contact-form/contact-form.component';
import { ContactDescrComponent } from './contact-descr/contact-descr.component';
import { FontAwesomeModule } from '../../../node_modules/@fortawesome/angular-fontawesome';
import { FormsModule } from '../../../node_modules/@angular/forms';

@NgModule({
  imports: [CommonModule, FontAwesomeModule, FormsModule],
  declarations: [ContactComponent, ContactFormComponent, ContactDescrComponent]
})
export class ContactModule {}
