export interface LocalizationInformation {
  house_number: number;
  road: string;
  commercial: string;
  suburb: string;
  city_district: string;
  city: string;
  county: string;
  state: string;
  postcode: string;
  country: string;
  country_code: string;
}

export interface LocalizationReverseInfo {
  place_id: string;
  licence: string;
  osm_type: string;
  osm_id: string;
  lat: string;
  lon: string;
  display_name: string;
  address: LocalizationInformation;
  boundingbox: Array<number>;
}
