import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { TaskItem } from 'src/app/_interfaces/_models/task-item';
import { ITaskItemService } from '../../_interfaces/ITaskItemService';

@Injectable({
  providedIn: 'root'
})
export class MockTaskItemService  implements ITaskItemService {

  private mockTaskItems: TaskItem[] = [
    {
      id: 1,
      parentId: 0,
      minutesEstimated: 0,
      minutesSpent: 0,
      dueDate: "2021/06/15 10:00:00",
      title: "Mock - Try to take over the world",
      shortDescription:"We need to attempt to control the entire world. Starting from A proceeding to Z",
      assignedUserId: 1,
      isDeleting: false
  },
  {
    id: 2,
    parentId: 1,
    minutesEstimated: 0,
    minutesSpent: 0,
    dueDate: "2021/06/15 10:00:00",
    title: "Find Pinky",
    shortDescription:"Pinky can do the hard work",
    assignedUserId: 2,
    isDeleting: false
},
{
  id: 3,
  parentId: 1,
  minutesEstimated: 0,
  minutesSpent: 0,
  dueDate: "2021/06/15 10:00:00",
  title: "Find Brain",
  shortDescription:"Brain will control the operation",
  assignedUserId: 1,
  isDeleting: false
},
{
  id: 4,
  parentId: 0,
  minutesEstimated: 0,
  minutesSpent: 0,
  dueDate: "2021/09/22 9:00:00",
  title: "Mock - High Level Task 2",
  shortDescription:"Lorem ipsum dolores amet",
  assignedUserId: 1,
  isDeleting: false
},
  ]
  
  constructor() { }
  getAllHighLevelTasks(): Observable<TaskItem[]> {
    return of(this.mockTaskItems.filter(t => t.parentId === 0));    
  }
  getTaskById(taskId: number): Observable<TaskItem> {
    let output = this.doesExist(this.mockTaskItems.find(t => t.id === taskId));
    return of(output);    
  }
  getChildTasks(parentId: number): Observable<TaskItem[]> {
    let output = this.mockTaskItems.filter(t => t.parentId === parentId);
    return of(output);    
  }


  private doesExist<T>(argument: T | undefined | null, message: string = 'This value was promised to be there.'): T {
    if (argument === undefined || argument === null) {
      throw new TypeError(message);
    }  
    return argument;
  }
}
