import { Company } from "./company";

export interface Course {
  id: number;
  name: string;
  link: string;
  description: string;
  company: Company;
  companyId: number;
}
