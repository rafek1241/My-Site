import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Config } from "../models/config";
import { APP_CONFIG } from "./education.service";
import { ThirdPartyApp } from "../models/third-party-app";
import { AppAdditionalInformationService } from "./app-additional-information.service";
import { forkJoin, Observable } from "rxjs";
import { map } from "rxjs/operators";
import { ApiModule } from "./api.module";

@Injectable({
  providedIn: ApiModule
})
export class ThirdPartyAppService {
  private _thirdPartyApps$: Observable<ThirdPartyApp[]>;

  constructor(
    private http: HttpClient,
    private appAdditionalInformationService: AppAdditionalInformationService,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this._thirdPartyApps$ = forkJoin(
      http.get<ThirdPartyApp[]>(config.api + "third-party-app"),
      appAdditionalInformationService.additionalInformations$
    ).pipe(
      map(res => {
        const thirdPartyApps = res[0];
        const additionalInformations = res[1];

        thirdPartyApps.forEach(element => {
          element.appAdditionalInformations = additionalInformations.filter(
            w => w.thirdPartyAppId === element.id
          );
        });

        return thirdPartyApps;
      })
    );
  }

  /**
   * Getter thirdPartyApps$
   * @return {Observable<ThirdPartyApp[]>}
   */
  public get thirdPartyApps$(): Observable<ThirdPartyApp[]> {
    return this._thirdPartyApps$;
  }
}
