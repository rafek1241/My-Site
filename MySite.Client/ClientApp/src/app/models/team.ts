import { Award } from "./award";
import { Person } from "./person";
export interface Team {
  teamId: number;
  name: string;
  award: Award;
  persons: Person[];
}
