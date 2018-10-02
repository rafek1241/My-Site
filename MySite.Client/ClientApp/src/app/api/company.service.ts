import { APP_CONFIG } from "./education.service";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { Injectable, Inject, Type } from "@angular/core";
import { Config } from "../models/config";
import { Company } from "../models/company";

type RESOURCE_TYPE = Company;

@Injectable()
export class CompanyService {
  private RESOURCE_NAME = "company";

  private _companyList$: Observable<RESOURCE_TYPE[]>;

  constructor(private http: HttpClient, @Inject(APP_CONFIG) config: Config) {
    this._companyList$ = this.http.get<RESOURCE_TYPE[]>(
      config.api + this.RESOURCE_NAME
    );
  }

  /**
   * Getter companyList$
   * @return {Observable<Company[]>}
   */
  public get companyList$(): Observable<RESOURCE_TYPE[]> {
    return this._companyList$;
  }
}
