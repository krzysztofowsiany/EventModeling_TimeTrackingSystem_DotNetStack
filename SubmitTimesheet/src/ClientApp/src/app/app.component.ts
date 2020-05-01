import {Component, Inject} from '@angular/core';
import {SubmitTimesheet} from "./SubmitTimesheet";
import { HttpClient } from '@angular/common/http';
import {catchError} from "rxjs/operators";
import {of} from "rxjs";
import * as uuid from 'uuid';
import * as moment from 'moment';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  submitTimesheet = new SubmitTimesheet();

  constructor(private httpClient: HttpClient,  @Inject('BASE_URL') private baseUrl: string) {
    this.generateAll();
  }

  generateDates(){
    this.submitTimesheet.StartDate = moment().toDate();
    this.submitTimesheet.EndDate = moment().add(10,'h').toDate();
  }


  generateGuidForTimesheetId(){
    this.submitTimesheet.TimesheetId =  uuid.v4();
  }

  generateGuidForUserId(){
    this.submitTimesheet.UserId =  uuid.v4();
  }
  generateAll(){
    this.generateGuidForTimesheetId();
    this.generateDates();
    this.generateGuidForUserId();
  }

  submit() {
    console.log("try subbmit");
    this.httpClient
      .post(`${this.baseUrl}api/timesheet/submitTimesheet`, this.submitTimesheet).subscribe(result => {
    }, error => console.error(error));
  }
}
