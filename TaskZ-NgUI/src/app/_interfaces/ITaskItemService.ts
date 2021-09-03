import { Observable } from "rxjs";
import { TaskItem } from "./_models/task-item";

//interface provided so that I can derive a mock service to return objects without running the actual API
export interface ITaskItemService{    
    getAllHighLevelTasks(): Observable<TaskItem[]>;    
    getTaskById(taskId: number): Observable<TaskItem>;    
    getChildTasks(parentId: number): Observable<TaskItem[]>;
}