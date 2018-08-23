import { Education } from "./../../models/education";
import { EducationService } from "./../../api/education.service";
import { Component, OnInit, OnDestroy } from "@angular/core";
import { Observable, BehaviorSubject } from "rxjs";

@Component({
  selector: "app-education",
  templateUrl: "./education.component.html",
  styleUrls: ["./education.component.scss"]
})
export class EducationComponent implements OnInit {
  educationList: BehaviorSubject<Education[]>;

  constructor(private educationService: EducationService) {}

  ngOnInit() {
    this.educationList = this.educationService.getEducationList();
  }
}
