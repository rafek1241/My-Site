import { Component } from "@angular/core";
import { Award } from "../../models/award";
import { Observable } from "rxjs";
import { AwardService } from "../../api/award.service";

@Component({
  selector: "app-awards",
  templateUrl: "./awards.component.html",
  styleUrls: ["./awards.component.scss"]
})
export class AwardsComponent {
  private awardList: Observable<Award[]>;

  constructor(private awardService: AwardService) {
    this.awardList = awardService.$awardList$;
  }

  /**
   * Getter $awardList
   * @return {Observable<Award[]>}
   */
  public get $awardList(): Observable<Award[]> {
    return this.awardList;
  }
}
