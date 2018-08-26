import { Config } from "./../models/Config";
import { APP_CONFIG } from "./education.service";
import { HttpClient } from "@angular/common/http";
import { Injectable, Inject } from "@angular/core";
import { Observable } from "rxjs";
import { Localization } from "../models/localization";

@Injectable()
export class LocalizationService {
  private _localizationList$: Observable<Localization[]>;

  constructor(private http: HttpClient, @Inject(APP_CONFIG) config: Config) {
    this._localizationList$ = this.http.get<Localization[]>(
      config.api + "localization"
    );
  }

  /**
   * Getter localizationList$
   * @return {Observable<Localization[]>}
   */
  public get localizationList$(): Observable<Localization[]> {
    return this._localizationList$;
  }
}
