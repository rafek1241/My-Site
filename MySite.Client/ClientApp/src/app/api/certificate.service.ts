import { Injectable, Inject } from "@angular/core";
import { Observable, forkJoin } from "rxjs";
import { Certificate } from "../models/certificate";
import { HttpClient } from "@angular/common/http";
import { APP_CONFIG } from "./education.service";
import { Config } from "../models/config";
import { ApiModule } from "./api.module";
import { CompanyService } from "./company.service";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: ApiModule
})
export class CertificateService {
  private _certificates$: Observable<Certificate[]>;

  constructor(
    private http: HttpClient,
    private companyService: CompanyService,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this._certificates$ = forkJoin(
      http.get<Certificate[]>(config.api + "certificate"),
      companyService.companyList$
    ).pipe(
      map(w => {
        const certificates = w[0];
        const companies = w[1];

        certificates.forEach(element => {
          element.institution = companies.find(
            p => p.id === element.institutionId
          );
        });

        return certificates;
      })
    );
  }

  public get certificates$(): Observable<Certificate[]> {
    return this._certificates$;
  }
}
