import { SkillCategory } from "./skill-category";

export interface Skill {
  id: number;
  iconBase64: string;
  name: string;
  level: number;
  styles: any;
  skillCategory: SkillCategory;
  skillCategoryId: number;
}
