import { TestBed, inject } from '@angular/core/testing';

import { WorkPositionService } from './work-position.service';

describe('WorkPositionService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WorkPositionService]
    });
  });

  it('should be created', inject([WorkPositionService], (service: WorkPositionService) => {
    expect(service).toBeTruthy();
  }));
});
