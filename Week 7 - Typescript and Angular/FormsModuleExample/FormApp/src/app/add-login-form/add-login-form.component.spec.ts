import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddLoginFormComponent } from './add-login-form.component';

describe('AddLoginFormComponent', () => {
  let component: AddLoginFormComponent;
  let fixture: ComponentFixture<AddLoginFormComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddLoginFormComponent]
    });
    fixture = TestBed.createComponent(AddLoginFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
