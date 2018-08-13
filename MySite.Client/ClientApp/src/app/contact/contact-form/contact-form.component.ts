import { Component, OnInit } from '@angular/core';
import { faEnvelope, faRedo } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.scss']
})
export class ContactFormComponent {
  faEnvelope = faEnvelope;
  faRedo = faRedo;
  form: MailForm;

  constructor() {
    this.form = {
      email: '',
      message: ''
    };
  }

  submit(form: NgForm) {
    console.log(form, form.value);
  }

  get diagnostic() {
    return JSON.stringify(this.form);
  }
}

interface MailForm {
  email: string;
  message: string;
}
