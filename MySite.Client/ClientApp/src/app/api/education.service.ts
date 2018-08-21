import { EducationDegree } from "./../models/education-degree";
import { Injectable, Inject, InjectionToken, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import {
  BehaviorSubject,
  Observable,
  forkJoin,
  merge,
  combineLatest
} from "rxjs";
import { switchMap, map, zip, tap } from "rxjs/operators";
import { Education } from "../models/education";

export const APP_CONFIG = new InjectionToken<Config>("APP_CONFIG");

export class EducationService {
  educationListObservable: Observable<any>;
  educationDegreeListObservable: Observable<EducationDegree[]>;
  educationList$ = new BehaviorSubject<Education[]>([]);
  config: Config;

  constructor(private http: HttpClient, @Inject(APP_CONFIG) config: Config) {
    this.config = config;
    console.log(this);

    this.educationListObservable = forkJoin(
      this.http.get<Education[]>(config.api + "education"),
      this.http.get<EducationDegree[]>(config.api + "educationDegree")
    ).pipe(
      map(val => {
        const eduDegree = val[1];
        const edu = val[0];

        edu.forEach(
          v => (v.degree = eduDegree.find(d => d.id === v.educationDegreeId))
        );

        return edu;
      })
    );

    // this.educationListObservable.pipe(
    //   tap(p => console.log(p)),
    //   map((value, idx) => {
    //     this.educationDegreeListObservable.subscribe(result => {
    //       value.forEach(edu => {
    //         edu.degree = result.find(p => p.id === edu.educationDegreeId);
    //       });
    //     });
    //   }),
    //   tap(p => console.log(p))
    // );
  }

  getEducationList(): Observable<Education[]> {
    return this.educationListObservable;
  }
}

export interface Config {
  api: string;
}
