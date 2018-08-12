import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AboutComponent } from './about/about.component';
import { CertificatesComponent } from './certificates/certificates.component';
import { AwardsComponent } from './awards/awards.component';
import { HobbiesComponent } from './hobbies/hobbies.component';
import { AdmiredPeopleComponent } from './admired-people/admired-people.component';
import { RecomendationsComponent } from './recomendations/recomendations.component';
import { CoursesComponent } from './courses/courses.component';
import { ArticlesComponent } from './articles/articles.component';
import { ThirdPartyComponent } from './third-party/third-party.component';
import { ExperienceComponent } from './experience/experience.component';
import { EducationComponent } from './education/education.component';
import { SkillsComponent } from './skills/skills.component';

@NgModule({
  imports: [CommonModule],
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
    SkillsComponent
  ],
  exports: [AboutComponent]
})
export class AboutModule {}
