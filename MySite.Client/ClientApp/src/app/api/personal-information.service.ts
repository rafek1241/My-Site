import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { APP_CONFIG } from "./education.service";
import { Config } from "../models/config";
import { PersonalInformation } from "../models/personal-information";
import { Observable, forkJoin } from "rxjs";
import { PersonService } from "./person.service";
import { map } from "rxjs/operators";
import { ApiModule } from "./api.module";

@Injectable({
  providedIn: ApiModule
})
export class PersonalInformationService {
  private _personalList$: Observable<PersonalInformation[]>;

  constructor(
    private http: HttpClient,
    private personService: PersonService,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this._personalList$ = forkJoin(
      http.get<PersonalInformation[]>(config.api + "personal-information"),
      personService.$personList$
    ).pipe(
      map(w => {
        const personalInfos = w[0];
        const people = w[1];

        personalInfos.forEach(
          p => (p.person = people.find(d => d.id === p.personId))
        );

        return personalInfos;
      })
    );
  }

  /**
   * Getter personalList$
   * @return {Observable<PersonalInformation[]>}
   */
  public get personalList$(): Observable<PersonalInformation[]> {
    return this._personalList$;
  }
}
