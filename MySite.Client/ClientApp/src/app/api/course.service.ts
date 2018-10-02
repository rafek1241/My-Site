import { Injectable, Inject } from "@angular/core";
import { ApiModule } from "./api.module";
import { Observable, forkJoin } from "rxjs";
import { APP_CONFIG } from "./education.service";
import { Config } from "protractor";
import { HttpClient } from "@angular/common/http";
import { Course } from "../models/course";
import { CompanyService } from "./company.service";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: ApiModule
})
export class CourseService {
  private _courses$: Observable<Course[]>;

  constructor(
    private http: HttpClient,
    private companyService: CompanyService,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this._courses$ = forkJoin(
      http.get<Course[]>(config.api + "course"),
      companyService.companyList$
    ).pipe(
      map(w => {
        const courses = w[0];
        const companies = w[1];

        courses.forEach(element => {
          element.company = companies.find(p => p.id === element.companyId);
        });

        return courses;
      })
    );
  }

  public get courses$(): Observable<Course[]> {
    return this._courses$;
  }
}
