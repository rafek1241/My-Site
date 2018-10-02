import { ExperienceService } from "./experience.service";
import { LocalizationService } from "./localization.service";
import { CompanyService } from "./company.service";
import { environment } from "./../../environments/environment";
import { MottoService } from "./motto.service";
import { NgModule, InjectionToken } from "@angular/core";
import { CommonModule } from "@angular/common";
import { EducationService, APP_CONFIG } from "./education.service";
import { HttpClientModule } from "@angular/common/http";
import { WorkPositionService } from "./work-position.service";

@NgModule({
  imports: [CommonModule, HttpClientModule],
  declarations: [],
  providers: [
    {
      provide: APP_CONFIG,
      useValue: environment
    },
    MottoService,
    EducationService,
    CompanyService,
    LocalizationService,
    WorkPositionService,
  ]
})
export class ApiModule {}
