import { TestBed } from '@angular/core/testing';

import { FirstComponentServiceService } from './first-component-service.service';

describe('FirstComponentServiceService', () => {
  let service: FirstComponentServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FirstComponentServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
