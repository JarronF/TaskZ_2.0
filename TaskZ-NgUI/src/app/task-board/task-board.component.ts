import { Component, OnInit } from '@angular/core';
import { TaskItemService } from '../task-item.service';
import { TaskItem } from '../_models/task-item';

@Component({
  selector: 'app-task-board',
  templateUrl: './task-board.component.html',
  styleUrls: ['./task-board.component.css']
})
export class TaskBoardComponent implements OnInit {
  public tasks: TaskItem[] = [];
  constructor(private taskItemService: TaskItemService) { }
  
  ngOnInit(): void {
    this.getParentTasks();
  }
  getParentTasks() {
    this.taskItemService.getAllHighLevelTasks()
        .subscribe(tasks => this.tasks = tasks);
  }

  deleteTask(id: number){
    
  }
}
