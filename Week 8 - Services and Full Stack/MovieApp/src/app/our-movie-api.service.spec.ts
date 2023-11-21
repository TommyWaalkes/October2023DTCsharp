import { TestBed } from '@angular/core/testing';

import { OurMovieAPIService } from './our-movie-api.service';

describe('OurMovieAPIService', () => {
  let service: OurMovieAPIService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OurMovieAPIService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
