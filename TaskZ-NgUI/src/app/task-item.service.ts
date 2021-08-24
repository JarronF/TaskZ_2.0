import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { TaskItem } from './_models/task-item';
@Injectable({
  providedIn: 'root'
})
export class TaskItemService {
  private taskItemsUrl = 'https://localhost:44306/api/TaskItem';
  
  constructor(
    private http: HttpClient    
  ) { }

  public getAllHighLevelTasks(){
    let url = this.taskItemsUrl + "/GetAllHighLevelTaskItems";
    return this.http.get<TaskItem[]>(url);    
  }
}
