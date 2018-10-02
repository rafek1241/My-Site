import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { ApiModule } from "./api.module";
import { APP_CONFIG } from "./education.service";
import { Config } from "../models/config";
import { Person } from "../models/person";
import { Observable } from "rxjs";

@Injectable({
  providedIn: ApiModule
})
export class PersonService {
  private personList$: Observable<Person[]>;

  constructor(
    private http: HttpClient,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this.personList$ = http.get<Person[]>(config.api + "person");
  }

  /**
   * Getter $personList$
   * @return {Observable<Person[]>}
   */
  public get $personList$(): Observable<Person[]> {
    return this.personList$;
  }
}
