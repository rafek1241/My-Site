import { WorkPositionService } from './work-position.service';
import { LocalizationService } from "./localization.service";
import { CompanyService } from "./company.service";
import { APP_CONFIG } from "./education.service";
import { HttpClient } from "@angular/common/http";
import { Injectable, Inject } from "@angular/core";
import { Config } from "../models/Config";
import { Observable, forkJoin } from "rxjs";
import { Experience } from "../models/experience";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: "root"
})
export class ExperienceService {
  private _experienceList$: Observable<Experience[]>;

  constructor(
    private http: HttpClient,
    private companyService: CompanyService,
    private localizationService: LocalizationService,
    private workPositionService: WorkPositionService,
    @Inject(APP_CONFIG) config: Config
  ) {
    this._experienceList$ = forkJoin(
      this.http.get<Experience[]>(config.api + "experience"),
      companyService.companyList$,
      localizationService.localizationList$,
      workPositionService.workPositionList$
    ).pipe(map(p => {
      const companies = p[1];
      const localization = p[2];
      const workPositions = p[3];
      const experience = p[0];

      experience.forEach(d => {
       d.company = companies.find(w => w.id === d.companyId);
       d.localization = localization.find(w => w.id === d.localizationId);
       d.position = workPositions.find(w => w.id === d.positionId);
      });

      return experience;
    }));
  }

  /**
   * Getter experienceList$
   * @return {Observable<Experience[]>}
   */
  public get experienceList$(): Observable<Experience[]> {
    return this._experienceList$;
  }
}
