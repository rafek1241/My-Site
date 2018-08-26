import { APP_CONFIG } from "./education.service";
import { Company } from "./../models/company";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { Injectable, Inject } from "@angular/core";
import { Config } from "../models/Config";

@Injectable()
export class CompanyService {
  private _companyList$: Observable<Company[]>;

  constructor(private http: HttpClient, @Inject(APP_CONFIG) config: Config) {
    this._companyList$ = this.http.get<Company[]>(config.api + "company");
  }

  /**
   * Getter companyList$
   * @return {Observable<Company[]>}
   */
  public get companyList$(): Observable<Company[]> {
    return this._companyList$;
  }
}
