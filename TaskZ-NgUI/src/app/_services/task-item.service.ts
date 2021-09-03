import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { TaskItem } from '../_interfaces/_models/task-item';
import { ITaskItemService } from '../_interfaces/ITaskItemService';
@Injectable({
  providedIn: 'root'
})
export class TaskItemService implements ITaskItemService {

  private taskItemsUrl = 'https://localhost:44306/api/TaskItem';
  
  constructor(
    private http: HttpClient    
  ) { }

  public getAllHighLevelTasks(){
    let url = this.taskItemsUrl + "/GetAllHighLevelTaskItems";
    return this.http.get<TaskItem[]>(url);    
  }
  public getTaskById(id: number){
    let url = this.taskItemsUrl + `/GetTaskItem/${id}`;
    return this.http.get<TaskItem>(url);    
  }

  public getChildTasks(id: number) {
    let url = this.taskItemsUrl + `/GetChildTasks/${id}`;
    return this.http.get<TaskItem[]>(url);    
  }
}
