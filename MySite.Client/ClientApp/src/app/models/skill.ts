import { SkillCategory } from "./skill-category";

export interface Skill {
  skillId: number;
  iconBase64: string;
  name: string;
  level: number;
  skillCategory: SkillCategory;
}
