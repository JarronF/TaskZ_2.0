import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
@Component({
  selector: 'app-task-add-edit',
  templateUrl: './task-add-edit.component.html',
  styleUrls: ['./task-add-edit.component.css']
})
export class TaskAddEditComponent implements OnInit {
  taskId: string = "";
  isAddMode: boolean = true;

  taskForm = this.formBuilder.group({
    title: [""],
    description:  [""],
    dueDate: [""],
    minutesSpent:  [""],
    minutesEstimated:  [""]
  });

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private formBuilder: FormBuilder
    ) { }

  ngOnInit(): void {
    this.taskId = this.route.snapshot.params["id"];
    this.isAddMode = ! this.taskId;
  }

  onSubmit():void{
      // TODO: Use EventEmitter with form value
    console.warn(this.taskForm.value);
  }
}
