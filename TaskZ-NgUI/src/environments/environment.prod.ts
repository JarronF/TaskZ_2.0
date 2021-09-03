import { TaskItemService } from "src/app/_services/task-item.service";
import { MockTaskItemService } from "src/app/_services/_mocks/mock-task-item.service";

export const environment = {
  production: true,
  providers: [
    { provide: TaskItemService, useClass: MockTaskItemService },
  ]
};
