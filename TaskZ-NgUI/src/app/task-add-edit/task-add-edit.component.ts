import { Component, Input, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MockTaskItemService } from '../_services/_mocks/mock-task-item.service';
import { formatDate, DatePipe } from '@angular/common' 
import { TaskItem } from '../_interfaces/_models/task-item';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-task-add-edit',
  templateUrl: './task-add-edit.component.html',
  styleUrls: ['./task-add-edit.component.css']
})
export class TaskAddEditComponent implements OnInit {
  parentId?: number;
  taskId?: number;
  isAddMode: boolean = true;
  task?: TaskItem; 
  submitted = false;
  loading = false;  
  parentTitle?: string;  

  taskForm = this.formBuilder.group({
    title: ["", Validators.required],
    shortDescription:  [""],
    dueDate: ["", Validators.required],
    minutesEstimated: [""],
    minutesSpent: [""],
    parent: this.route.snapshot.params["parentTitle"],   
  }); 

  // convenience getter for easy access to form fields
  get f() { return this.taskForm.controls; }

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private formBuilder: FormBuilder,
    private taskItemService: MockTaskItemService
    ) {     }
    
  ngOnInit(): void {
    this.taskId = Number(this.route.snapshot.params["id"]);
    this.parentId = Number(this.route.snapshot.params["parentId"]);

    this.isAddMode = ! this.taskId;

    if (this.isAddMode == false) {
      this.getTaskById(this.taskId);
    }        
  } 

  getTaskById(id: number) {    
    this.taskItemService.getTaskById(id)
        .pipe(first())        
        .subscribe(t => {
          this.task = t,
          this.task.dueDate = formatDate(t.dueDate, 'yyyy-MM-dd', 'en'),
          this.taskForm.patchValue(this.task)
          
        });   
  }  
  onSubmit() {
    this.submitted = true;

    // reset alerts on submit
   // this.alertService.clear();

    // stop here if form is invalid
    if (this.taskForm.invalid) {
        return;
    }

    this.loading = true;
    /*if (this.isAddMode) {
        this.createUser();
    } else {
        this.updateUser();
    }*/
}
}
