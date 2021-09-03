import { TestBed } from '@angular/core/testing';

import { MockTaskItemService } from './mock-task-item.service';

describe('MockTaskItemService', () => {
  let service: MockTaskItemService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MockTaskItemService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
