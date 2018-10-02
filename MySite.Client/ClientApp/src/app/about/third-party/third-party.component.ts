import { Component, OnInit } from "@angular/core";
import { ThirdPartyAppService } from "../../api/third-party-app.service";
import { ThirdPartyApp } from "../../models/third-party-app";
import { Observable } from "rxjs";
import { AppAdditionalInformation } from "../../models/app-additional-information";
import { Styles } from "@fortawesome/fontawesome-svg-core";

@Component({
  selector: "app-third-party",
  templateUrl: "./third-party.component.html",
  styleUrls: ["./third-party.component.scss"]
})
export class ThirdPartyComponent implements OnInit {
  thirdPartyAppList$: Observable<ThirdPartyApp[]>;

  constructor(private thirdPartyAppService: ThirdPartyAppService) {}

  ngOnInit() {
    this.thirdPartyAppList$ = this.thirdPartyAppService.thirdPartyApps$;
  }

  /**
   * convertToDictionaryObject
   */
  public convertToDictionaryObject(array: AppAdditionalInformation[]): Styles {
    const styles: Styles = {};

    array.forEach(element => {
      styles[element.key] = element.value;
    });

    return styles;
  }
}
