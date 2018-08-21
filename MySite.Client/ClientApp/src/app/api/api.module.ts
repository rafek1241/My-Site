import { environment } from "./../../environments/environment";
import { MottoService } from "./motto.service";
import { NgModule, InjectionToken } from "@angular/core";
import { CommonModule } from "@angular/common";
import { EducationService, APP_CONFIG } from "./education.service";
import { HttpClientModule } from "@angular/common/http";

@NgModule({
  imports: [CommonModule, HttpClientModule],
  declarations: [],
  providers: [
    {
      provide: APP_CONFIG,
      useValue: environment
    },
    MottoService,
    EducationService
  ]
})
export class ApiModule {}
