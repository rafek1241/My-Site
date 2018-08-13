import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactDescrComponent } from './contact-descr.component';

describe('ContactDescrComponent', () => {
  let component: ContactDescrComponent;
  let fixture: ComponentFixture<ContactDescrComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ContactDescrComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ContactDescrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
