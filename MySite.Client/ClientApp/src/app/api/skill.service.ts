import { Injectable, Inject } from "@angular/core";
import { Observable, forkJoin } from "rxjs";
import { Skill } from "../models/skill";
import { HttpClient } from "@angular/common/http";
import { APP_CONFIG } from "./education.service";
import { Config } from "../models/config";
import { ApiModule } from "./api.module";
import { SkillCategoryService } from "./skill-category.service";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: ApiModule
})
export class SkillService {
  private skillList$: Observable<Skill[]>;

  constructor(
    private http: HttpClient,
    private skillCategoryService: SkillCategoryService,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this.skillList$ = forkJoin(
      http.get<Skill[]>(config.api + "skill"),
      skillCategoryService.skillCategoryList$
    ).pipe(
      map(resource => {
        const skills = resource[0];
        const skillCategories = resource[1];

        skills.forEach(element => {
          element.skillCategory = skillCategories.find(
            el => el.id === element.skillCategoryId
          );
          element.styles.width = element.level + "%";
        });

        return skills;
      })
    );
  }

  /**
   * Getter $skillList$
   * @return {Observable<Skill[]>}
   */
  public get $skillList$(): Observable<Skill[]> {
    return this.skillList$;
  }
}
