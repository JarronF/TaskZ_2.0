import { Component, OnInit, Input, Output, EventEmitter, TemplateRef } from '@angular/core';
import { MockTaskItemService } from '../_services/_mocks/mock-task-item.service';
import { TaskItem } from '../_interfaces/_models/task-item';

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

  constructor(
    private taskItemService: MockTaskItemService,
    ) { }

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
