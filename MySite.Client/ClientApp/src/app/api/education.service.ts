import { EducationDegree } from "./../models/education-degree";
import { Inject, InjectionToken } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BehaviorSubject, forkJoin } from "rxjs";
import { map } from "rxjs/operators";
import { Education } from "../models/education";
import { Config } from "../models/config";

export const APP_CONFIG = new InjectionToken<Config>("APP_CONFIG");

export class EducationService {
  private educationList$ = new BehaviorSubject<Education[]>([]);
  config: Config;

  constructor(private http: HttpClient, @Inject(APP_CONFIG) config: Config) {
    this.config = config;

    forkJoin(
      this.http.get<Education[]>(config.api + "education"),
      this.http.get<EducationDegree[]>(config.api + "education-degree")
    )
      .pipe(
        map(val => {
          const eduDegree = val[1];
          const edu = val[0];

          edu.forEach(
            v => (v.degree = eduDegree.find(d => d.id === v.educationDegreeId))
          );

          return edu;
        })
      )
      .subscribe(v => this.educationList$.next(v));
  }

  getEducationList(): BehaviorSubject<Education[]> {
    return this.educationList$;
  }
}
