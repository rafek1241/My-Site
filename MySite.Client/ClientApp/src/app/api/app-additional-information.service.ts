import { Injectable, Inject } from "@angular/core";
import { Observable } from "rxjs";
import { AppAdditionalInformation } from "../models/app-additional-information";
import { HttpClient } from "@angular/common/http";
import { APP_CONFIG } from "./education.service";
import { Config } from "../models/config";
import { ApiModule } from "./api.module";

@Injectable({
  providedIn: ApiModule
})
export class AppAdditionalInformationService {
  private _additionalInformation$: Observable<AppAdditionalInformation[]>;

  constructor(
    private http: HttpClient,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this._additionalInformation$ = http.get<AppAdditionalInformation[]>(
      config.api + "app-additional-information"
    );
  }

  public get additionalInformations$(): Observable<AppAdditionalInformation[]> {
    return this._additionalInformation$;
  }
}
