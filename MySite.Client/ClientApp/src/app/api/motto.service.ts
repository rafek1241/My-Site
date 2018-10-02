import { Injectable, Inject } from "@angular/core";
import { APP_CONFIG } from "./education.service";
import { Config } from "../models/config";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Motto } from "../models/motto";

@Injectable()
export class MottoService {
  private _mottoList$: Observable<Motto[]>;

  constructor(
    private http: HttpClient,
    @Inject(APP_CONFIG) private config: Config
  ) {
    this._mottoList$ = http.get<Motto[]>(config.api + "motto");
  }

  /**
   * Getter mottoList$
   * @return {Observable<Motto[]>}
   */
  public get mottoList$(): Observable<Motto[]> {
    return this._mottoList$;
  }
}
