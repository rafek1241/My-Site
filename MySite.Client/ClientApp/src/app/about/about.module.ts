import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { AboutComponent } from "./about/about.component";
import { CertificatesComponent } from "./certificates/certificates.component";
import { AwardsComponent } from "./awards/awards.component";
import { HobbiesComponent } from "./hobbies/hobbies.component";
import { AdmiredPeopleComponent } from "./admired-people/admired-people.component";
import { RecomendationsComponent } from "./recomendations/recomendations.component";
import { CoursesComponent } from "./courses/courses.component";
import { ArticlesComponent } from "./articles/articles.component";
import { ThirdPartyComponent } from "./third-party/third-party.component";
import { ExperienceComponent } from "./experience/experience.component";
import { EducationComponent } from "./education/education.component";
import { SkillsComponent } from "./skills/skills.component";
import { PersonalInformationComponent } from "./personal-information/personal-information.component";
import { FontAwesomeModule } from "@fortawesome/angular-fontawesome";
import { AchievementsComponent } from "./achievements/achievements.component";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";

@NgModule({
  imports: [CommonModule, FontAwesomeModule, NgbModule],
  declarations: [
    AboutComponent,
    CertificatesComponent,
    AwardsComponent,
    HobbiesComponent,
    AdmiredPeopleComponent,
    RecomendationsComponent,
    CoursesComponent,
    ArticlesComponent,
    ThirdPartyComponent,
    ExperienceComponent,
    EducationComponent,
    SkillsComponent,
    PersonalInformationComponent,
    AchievementsComponent
  ],
  exports: [AboutComponent]
})
export class AboutModule {}
