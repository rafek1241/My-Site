import { BehaviorSubject, Observable } from "rxjs";
import { ExperienceService } from "./../../api/experience.service";
import { Component, OnInit } from "@angular/core";
import { Experience } from "../../models/experience";
import { LocalizationService } from "../../api/localization.service";

@Component({
  selector: "app-experience",
  templateUrl: "./experience.component.html",
  styleUrls: ["./experience.component.scss"]
})
export class ExperienceComponent implements OnInit {
  private _experienceList$: Observable<Experience[]>;

  constructor(
    private experienceService: ExperienceService,
    protected localizationService: LocalizationService
  ) {}

  ngOnInit() {
    this._experienceList$ = this.experienceService.experienceList$;
  }

  /**
   * Getter experienceList$
   * @return {Observable<Experience[]>}
   */
  public get experienceList$(): Observable<Experience[]> {
    return this._experienceList$;
  }
}
