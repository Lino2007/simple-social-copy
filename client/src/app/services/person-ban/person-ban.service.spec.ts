import { TestBed } from '@angular/core/testing';

import { PersonBanService } from './person-ban.service';

describe('PersonBanService', () => {
  let service: PersonBanService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PersonBanService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
