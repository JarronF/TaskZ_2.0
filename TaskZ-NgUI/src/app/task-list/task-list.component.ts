import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { TaskItemService } from '../task-item.service';
import { TaskItem } from '../_models/task-item';
@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {    
  @Input() taskList?: TaskItem[];
  @Input() childTaskList?: TaskItem[];
  @Input() listTitle?: string;
  @Input() parent?: TaskItem;
  @Input() parentTitle?: string;
  constructor(private taskItemService: TaskItemService) { }

  ngOnInit(): void {
  }
  
  @Output() selectSubTasksClick = new EventEmitter<TaskItem>();
  @Output() deleteTaskClick = new EventEmitter<number>();
  @Output() addTaskClick = new EventEmitter<TaskItem>();
  @Output() editTaskClick = new EventEmitter<number>();

  
  selectSubTasks(value: TaskItem) {
    this.selectSubTasksClick.emit(value);
  }
  deleteTask(value: number) {
    this.deleteTaskClick.emit(value);
  }
  addTask(value?: TaskItem) {
    this.addTaskClick.emit(value);
  }
  editTask(value: number) {
    this.editTaskClick.emit(value);
  }
}
