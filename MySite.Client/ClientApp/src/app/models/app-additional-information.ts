import { ThirdPartyApp } from "./third-party-app";

export interface AppAdditionalInformation {
  id: number;
  thirdPartyAppId: number;
  thirdPartyApp: ThirdPartyApp;
  key: string;
  value: any;
}
