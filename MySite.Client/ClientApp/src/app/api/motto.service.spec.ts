import { TestBed, inject } from '@angular/core/testing';

import { MottoService } from './motto.service';

describe('MottoService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MottoService]
    });
  });

  it('should be created', inject([MottoService], (service: MottoService) => {
    expect(service).toBeTruthy();
  }));
});
