import { Observable } from "rxjs";
import { WorkPosition } from "./../models/work-position";
import { Config } from "./../models/Config";
import { APP_CONFIG } from "./education.service";
import { HttpClient } from "@angular/common/http";
import { Injectable, Inject } from "@angular/core";

@Injectable()
export class WorkPositionService {
  private _workPositionList$: Observable<WorkPosition[]>;

  constructor(private http: HttpClient, @Inject(APP_CONFIG) config: Config) {
    this._workPositionList$ = this.http.get<WorkPosition[]>(
      config.api + "work-position"
    );
  }

  /**
   * Getter workPositionList$
   * @return {Observable<WorkPosition[]>}
   */
  public get workPositionList$(): Observable<WorkPosition[]> {
    return this._workPositionList$;
  }
}
