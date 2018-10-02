import { AppAdditionalInformation } from "./app-additional-information";

export interface ThirdPartyApp {
  id: number;
  link: string;
  icon: string;
  appAdditionalInformations: AppAdditionalInformation[];
}
