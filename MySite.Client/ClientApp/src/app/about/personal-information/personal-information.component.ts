import { Component, OnInit } from "@angular/core";
import { PersonalInformationService } from "../../api/personal-information.service";
import { PersonalInformation } from "../../models/personal-information";

@Component({
  selector: "app-personal-information",
  templateUrl: "./personal-information.component.html",
  styleUrls: ["./personal-information.component.scss"]
})
export class PersonalInformationComponent implements OnInit {
  currentPersonalInformation: PersonalInformation;

  constructor(private personalInformationService: PersonalInformationService) {}

  ngOnInit() {
    this.personalInformationService.personalList$.subscribe(
      p => (this.currentPersonalInformation = p.pop())
    );
  }
}
