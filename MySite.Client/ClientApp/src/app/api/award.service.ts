import { Injectable, Inject } from "@angular/core";
import { Observable, forkJoin } from "rxjs";
import { Team } from "../models/team";
import { ApiModule } from "./api.module";
import { HttpClient } from "@angular/common/http";
import { TeamService } from "./team.service";
import { APP_CONFIG } from "./education.service";
import { Config } from "../models/Config";
import { Award } from "src/app/models/award";
import { map } from "rxjs/operators";
import { CompanyService } from "./company.service";

@Injectable({
  providedIn: ApiModule
})
export class AwardService {
  private awardList$: Observable<Award[]>;

  constructor(
    private http: HttpClient,
    private teamService: TeamService,
    private companyService: CompanyService,
    @Inject(APP_CONFIG) config: Config
  ) {
    this.awardList$ = forkJoin(
      http.get<Award[]>(config.api + "award"),
      teamService.teamList$,
      companyService.companyList$
    ).pipe(
      map(p => {
        const awards = p[0];
        const teams = p[1];
        const companies = p[2];

        awards.forEach(element => {
          element.team = teams.find(w => w.id === element.teamId);
          element.company = companies.find(w => w.id === element.companyId);
        });

        return awards;
      })
    );
  }

  /**
   * Getter $awardList$
   * @return {Observable<Award[]>}
   */
  public get $awardList$(): Observable<Award[]> {
    return this.awardList$;
  }
}
