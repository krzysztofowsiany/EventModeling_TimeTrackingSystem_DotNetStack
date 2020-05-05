import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Project } from './Project';
import * as uuid from 'uuid';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  project = new Project();

  constructor(private httpClient: HttpClient,  @Inject('BASE_URL') private baseUrl: string) {
    this.generateIds();
  }


  submit() {
    console.log(this.project);
    this.httpClient
      .post(`${this.baseUrl}api/project/create`, this.project).subscribe(result => {
    }, error => console.error(error));
  }


  generateIds() {
    const n = this.getRandomInt(1, 50);
    this.project.ProjectId =  uuid.v4();
    this.project.ProjectOwnerId =  uuid.v4();
    this.project.Name= `Name ${n}`;
  }

  private getRandomInt(min: number, max: number) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }
}
