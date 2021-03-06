import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TaskBoardComponent } from './task-board/task-board.component';
import { TaskAddEditComponent } from './task-add-edit/task-add-edit.component';

const routes: Routes = [
  { path: '', redirectTo: '/taskboard', pathMatch: 'full'},
  { path: 'taskboard', component: TaskBoardComponent }, //show task board listing
  { path: 'task/add', component: TaskAddEditComponent }, //add new task
  { path: 'task/add/:parentId/:parentTitle', component: TaskAddEditComponent }, //add new subtask
  { path: 'task/edit/:id', component: TaskAddEditComponent }, //edit task
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
