import { Company } from "./company";

export interface Certificate {
  id: number;
  /**Exam title */
  title: string;
  license: string;
  description: string;
  certificateBegin: Date;
  /**null if certificate is for a lifetime. */
  certificateEnd?: Date | string;
  url: string;
  photoBase64: string;
  institution: Company;
  institutionId: number;
}
