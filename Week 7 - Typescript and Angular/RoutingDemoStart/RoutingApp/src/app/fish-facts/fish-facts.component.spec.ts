import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FishFactsComponent } from './fish-facts.component';

describe('FishFactsComponent', () => {
  let component: FishFactsComponent;
  let fixture: ComponentFixture<FishFactsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FishFactsComponent]
    });
    fixture = TestBed.createComponent(FishFactsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
