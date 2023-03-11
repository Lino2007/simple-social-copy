import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { PersonService } from '../services/person/person.service';
import { ErrorResponse } from '../shared/ErrorResponse';
import { Person } from '../shared/Person';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
  @ViewChild('form', { static: false }) regForm!: NgForm;
  requestProcessing = false;
  apiResponseMessage = '';
  apiError = false;
  registerButtonDisable = false;

  constructor(private personService: PersonService, private router: Router) { }

  ngOnInit(): void {
  }

  check(firstname: any) {
    console.log("in");
    console.log(firstname);
  }

  onSubmit() {
    if (!this.regForm.invalid) {
      const person = <Person>this.regForm.value;
      this.resetVariables();
      this.personService.registerPerson(person).subscribe({
        next: (result: Person | ErrorResponse) => {
          if ('detail' in result) {
            this.apiResponseMessage = result?.detail!;
            this.apiError = true;
          }
          else {
            this.registerButtonDisable = true;
            this.apiResponseMessage = 'You have successfully registered, redirecting you to sign in form...';
            setTimeout(() => {
              this.router.navigate(['/']);
            }, 2000);
          }
          this.requestProcessing = false;
        },
        error: (e: HttpErrorResponse) => {
          this.apiError = true;
          this.apiResponseMessage = 'Server cannot process your requests at this time, please try again later.'
          console.error(e);
          this.requestProcessing = false;
        }
      });
    }
  }

  private resetVariables() {
    this.requestProcessing = true;
    this.apiError = false;
    this.apiResponseMessage = '';
    this.registerButtonDisable = false;
  }
}
