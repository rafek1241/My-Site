import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdmiredPeopleComponent } from './admired-people.component';

describe('AdmiredPeopleComponent', () => {
  let component: AdmiredPeopleComponent;
  let fixture: ComponentFixture<AdmiredPeopleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdmiredPeopleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdmiredPeopleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
