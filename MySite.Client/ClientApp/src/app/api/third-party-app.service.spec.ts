import { TestBed, inject } from '@angular/core/testing';

import { ThirdPartyAppService } from './third-party-app.service';

describe('ThirdPartyAppService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ThirdPartyAppService]
    });
  });

  it('should be created', inject([ThirdPartyAppService], (service: ThirdPartyAppService) => {
    expect(service).toBeTruthy();
  }));
});
