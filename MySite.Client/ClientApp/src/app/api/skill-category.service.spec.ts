import { TestBed, inject } from '@angular/core/testing';

import { SkillCategoryService } from './skill-category.service';

describe('SkillCategoryService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SkillCategoryService]
    });
  });

  it('should be created', inject([SkillCategoryService], (service: SkillCategoryService) => {
    expect(service).toBeTruthy();
  }));
});
