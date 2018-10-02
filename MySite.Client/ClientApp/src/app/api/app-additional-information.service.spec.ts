import { TestBed, inject } from '@angular/core/testing';

import { AppAdditionalInformationService } from './app-additional-information.service';

describe('AppAdditionalInformationService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [AppAdditionalInformationService]
    });
  });

  it('should be created', inject([AppAdditionalInformationService], (service: AppAdditionalInformationService) => {
    expect(service).toBeTruthy();
  }));
});
