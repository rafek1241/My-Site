import { Award } from "./award";

export interface Company {
  id: number;
  name: string;
  information: string;
  photoBase64: string;
  awards?: Award[];
}
