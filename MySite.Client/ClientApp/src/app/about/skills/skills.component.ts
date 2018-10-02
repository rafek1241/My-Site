import { Component, OnInit } from "@angular/core";
import { SkillService } from "../../api/skill.service";
import { Observable } from "rxjs";
import { Skill } from "../../models/skill";

@Component({
  selector: "app-skills",
  templateUrl: "./skills.component.html",
  styleUrls: ["./skills.component.scss"]
})
export class SkillsComponent implements OnInit {
  private skills: Observable<Skill[]>;

  constructor(private skillService: SkillService) {
    this.skills = this.skillService.$skillList$;

  }

  ngOnInit() {
  }

  /**
   * Getter $skills
   * @return {Observable<Skill[]>}
   */
  public get skills$(): Observable<Skill[]> {
    return this.skills;
  }
}
