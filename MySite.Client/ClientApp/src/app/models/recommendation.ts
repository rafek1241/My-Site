import { Person } from "./person";
import { Company } from "./company";

export interface Recommendation {
  id: number;
  description: string;
  personId: number;
  companyId: number;
  person: Person;
  company: Company;
}
