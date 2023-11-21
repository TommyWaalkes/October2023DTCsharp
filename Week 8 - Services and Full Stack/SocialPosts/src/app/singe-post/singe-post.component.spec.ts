import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingePostComponent } from './singe-post.component';

describe('SingePostComponent', () => {
  let component: SingePostComponent;
  let fixture: ComponentFixture<SingePostComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SingePostComponent]
    });
    fixture = TestBed.createComponent(SingePostComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
