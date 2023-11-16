import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MakeNewGuessComponent } from './make-new-guess.component';

describe('MakeNewGuessComponent', () => {
  let component: MakeNewGuessComponent;
  let fixture: ComponentFixture<MakeNewGuessComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MakeNewGuessComponent]
    });
    fixture = TestBed.createComponent(MakeNewGuessComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
