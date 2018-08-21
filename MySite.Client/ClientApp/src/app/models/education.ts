import { EducationDegree } from "./education-degree";

export interface Education {
  id: number;
  place: string;
  specialization: string;
  educationBegin: Date;
  educationEnd?: Date;
  educationDegreeId: number;
  degree: EducationDegree;
}
