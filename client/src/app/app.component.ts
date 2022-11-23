import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Person } from './person';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title: string = 'client';
  people: Person[] = [];

  constructor(private http: HttpClient) {
  }

  ngOnInit() {
    this.http.get<Person[]>("https://localhost:7289/api/Person/person").subscribe(p => {
      this.people = p;
    });
  }
}
