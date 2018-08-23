import { Localization } from "./localization";
import { Company } from "./company";
import { WorkPosition } from "./work-position";

export interface Experience {
  experienceId: number;
  position: WorkPosition;
  company: Company;
  workBegin: Date;
  workEnd?: Date;
  localization: Localization;
}
