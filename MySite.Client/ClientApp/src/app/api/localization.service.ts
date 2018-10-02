import { Config } from "./../models/config";
import { APP_CONFIG } from "./education.service";
import { HttpClient } from "@angular/common/http";
import { Injectable, Inject } from "@angular/core";
import { Observable } from "rxjs";
import { Localization } from "../models/localization";
import {
  LocalizationInformation,
  LocalizationReverseInfo
} from "../models/localization-information";
import { map } from "rxjs/operators";

@Injectable()
export class LocalizationService {
  private _localizationList$: Observable<Localization[]>;

  constructor(
    private http: HttpClient,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this._localizationList$ = this.http
      .get<Localization[]>(config.api + "localization")
      .pipe(
        map(localizationArray => {
          localizationArray.forEach(element => {
            this.getLocalizationInfo(
              element.lattitude,
              element.longitude
            ).subscribe(
              localizationInfo =>
                (element.additionalInformation = localizationInfo)
            );
          });

          return localizationArray;
        })
      );
  }

  /**
   * Getter localizationList$
   * @return {Observable<Localization[]>}
   */
  public get localizationList$(): Observable<Localization[]> {
    return this._localizationList$;
  }

  public getLocalizationInfo(
    lattitude: number,
    longitude: number
  ): Observable<LocalizationInformation> {
    return this.http
      .get<LocalizationReverseInfo>(
        this.config.localizationApi + "&lat=" + lattitude + "&lon=" + longitude
      )
      .pipe(
        map<LocalizationReverseInfo, LocalizationInformation>(w => w.address)
      );
  }
}
