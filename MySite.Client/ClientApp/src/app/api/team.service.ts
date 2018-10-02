import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { APP_CONFIG } from "./education.service";
import { Config } from "../models/config";
import { Team } from "../models/team";
import { Observable, forkJoin } from "rxjs";
import { PersonService } from "./person.service";
import { ApiModule } from "./api.module";
import { map } from "rxjs/operators";
import { PersonTeam } from "../models/person-team";

@Injectable({
  providedIn: ApiModule
})
export class TeamService {
  private _teamList$: Observable<Team[]>;

  constructor(
    private http: HttpClient,
    private personService: PersonService,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this._teamList$ = forkJoin(
      http.get<Team[]>(config.api + "team"),
      personService.$personList$,
      http.get<PersonTeam[]>(config.api + "person-team")
    ).pipe(
      map(p => {
        const teams = p[0];
        const people = p[1];
        const personTeamConn = p[2];

        teams.forEach(element => {
          element.persons = people.filter(
            person =>
              personTeamConn
                .filter(w => w.teamId === element.id)
                .map(w => w.personId)
                .indexOf(person.id) >= 0
          );
        });

        return teams;
      })
    );
  }

  /**
   * Getter $teamList$
   * @return {Observable<Team[]>}
   */
  public get teamList$(): Observable<Team[]> {
    return this._teamList$;
  }
}
