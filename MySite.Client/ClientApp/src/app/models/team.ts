import { Award } from "./award";
import { Person } from "./person";

export interface Team {
  id: number;
  name: string;
  awardId: number;
  award: Award;
  persons: Person[];
}
