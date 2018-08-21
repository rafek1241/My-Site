import { Education } from "./../../models/education";
import { EducationService } from "./../../api/education.service";
import { Component, OnInit } from "@angular/core";
import { BehaviorSubject, Observable } from "rxjs";

@Component({
  selector: "app-education",
  templateUrl: "./education.component.html",
  styleUrls: ["./education.component.scss"]
})
export class EducationComponent implements OnInit {
  educationList: Observable<Education[]>;

  constructor(private educationService: EducationService) {}

  ngOnInit() {
    this.educationList = this.educationService.getEducationList();
  }
}
