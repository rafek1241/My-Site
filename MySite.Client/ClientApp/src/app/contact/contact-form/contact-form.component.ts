import { Component, OnInit } from "@angular/core";
import { faEnvelope, faRedo } from "@fortawesome/free-solid-svg-icons";
import { NgForm } from "../../../../node_modules/@angular/forms";

@Component({
  selector: "app-contact-form",
  templateUrl: "./contact-form.component.html",
  styleUrls: ["./contact-form.component.scss"]
})
export class ContactFormComponent {
  faEnvelope = faEnvelope;
  faRedo = faRedo;
  model: MailForm;

  constructor() {}

  submit(form: NgForm) {
    console.log(form, form.value);
    const mailForm: MailForm = form.value as MailForm;
    console.log(mailForm);
  }
}

interface MailForm {
  email: string;
  message: string;
}
