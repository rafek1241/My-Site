import { Team } from "./team";

export interface Award {
  awardId: string;
  title: string;
  description: string;
  company: string;
  awardDate: Date;
  photo: Uint8Array;
  team: Team;
}
