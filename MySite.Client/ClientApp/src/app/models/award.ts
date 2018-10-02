import { Team } from "./team";
import { Company } from "./company";

export interface Award {
  id: number;
  title: string;
  description: string;
  companyId: number;
  company: Company;
  awardDate: Date;
  photoBase64: string;
  team: Team;
  teamId: number;
}
