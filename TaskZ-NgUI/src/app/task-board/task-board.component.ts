import { Component, OnInit } from '@angular/core';
import { MockTaskItemService } from '../_services/_mocks/mock-task-item.service';
import { TaskItem } from '../_interfaces/_models/task-item';
import { Router } from '@angular/router';

@Component({
  selector: 'app-task-board',
  templateUrl: './task-board.component.html',
  styleUrls: ['./task-board.component.css']
})
export class TaskBoardComponent implements OnInit {
  public topLevelTasks?: TaskItem[];
  public childTaskList?: TaskItem[];
  public parentTask?: TaskItem;

  constructor(
    private taskItemService: MockTaskItemService,
    private router: Router) { }
  
  ngOnInit(): void {
    this.getParentTasks();
  }
  getParentTasks() {
    this.taskItemService.getAllHighLevelTasks()
        .subscribe(t => this.topLevelTasks = t);        
  }
  getChildTasks(parent: TaskItem){
    this.parentTask = parent;
    this.taskItemService.getChildTasks(this.parentTask.id)
        .subscribe(t => this.childTaskList = t);        
  }

  deleteTask(id: number){
    console.log(`Task deleted - ${id}`);
  }
  addTask(parent?: TaskItem){
    this.parentTask = parent;
    if(this.parentTask){
      console.log(`Task added - ${this.parentTask.id}`);
    }
    else{
      this.router.navigateByUrl("task/add");
    }
    
  }
  editTask(id: number){    
    this.router.navigateByUrl(`task/edit/${id}`);
  }

}
