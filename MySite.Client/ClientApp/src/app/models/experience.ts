import { Localization } from "./localization";
import { Company } from "./company";
import { WorkPosition } from "./work-position";

export interface Experience {
  id: number;
  positionId: number;
  position: WorkPosition;
  companyId: number;
  company: Company;
  workBegin: Date;
  workEnd?: Date;
  localizationId: number;
  localization: Localization;
}
