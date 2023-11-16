import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuessDisplayComponent } from './guess-display.component';

describe('GuessDisplayComponent', () => {
  let component: GuessDisplayComponent;
  let fixture: ComponentFixture<GuessDisplayComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GuessDisplayComponent]
    });
    fixture = TestBed.createComponent(GuessDisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
