import { LocalizationInformation } from "./localization-information";

export interface Localization {
  id: number;
  lattitude: number;
  longitude: number;
  accuracy: number;
  additionalInformation: LocalizationInformation;
}
