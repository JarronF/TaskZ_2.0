import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { TaskBoardComponent } from './task-board/task-board.component';
import { TaskAddEditComponent } from './task-add-edit/task-add-edit.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TaskListComponent } from './task-list/task-list.component';
import { environment } from 'src/environments/environment';

@NgModule({
  declarations: [
    AppComponent,
    TaskBoardComponent,    
    TaskAddEditComponent, 
    TaskListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    NgbModule
  ],  
  providers: [
    ...environment.providers,
],
  bootstrap: [AppComponent]
})
export class AppModule { }
