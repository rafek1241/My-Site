import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Config } from "../models/config";
import { SkillCategory } from "../models/skill-category";
import { Observable } from "rxjs";
import { APP_CONFIG } from "./education.service";
import { ApiModule } from "./api.module";

@Injectable({
  providedIn: ApiModule
})
export class SkillCategoryService {
  private _skillCategoryList$: Observable<SkillCategory[]>;

  constructor(private http: HttpClient, @Inject(APP_CONFIG) config: Config) {
    this._skillCategoryList$ = this.http.get<SkillCategory[]>(
      config.api + "skill-category"
    );
  }

  /**
   * Getter skillCategoryList$
   * @return {Observable<SkillCategory[]>}
   */
  public get skillCategoryList$(): Observable<SkillCategory[]> {
    return this._skillCategoryList$;
  }
}
