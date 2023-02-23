import {
  AfterViewInit,
  Component,
  ElementRef,
  OnDestroy,
  ViewChild,
} from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
})
export class SignupComponent implements AfterViewInit, OnDestroy {
  @ViewChild('nameInput', { static: true }) nameInput!: ElementRef;
  signupForm = this.fb.group({
    name: ['', [Validators.required, Validators.minLength(3)]],
    email: ['', Validators.required],
    password: ['', [Validators.required, Validators.minLength(3)]],
    rePassword: ['', [Validators.required, Validators.minLength(3)]],
  });

  signupSubscr!: Subscription;

  constructor(
    private fb: FormBuilder,
    private auth: AuthService,
    private router: Router
  ) {}

  get name() {
    return this.signupForm.get('name');
  }

  get email() {
    return this.signupForm.get('email');
  }

  get password() {
    return this.signupForm.get('password');
  }
  get rePassword() {
    return this.signupForm.get('rePassword');
  }
  ngAfterViewInit() {
    setTimeout(() => {
      this.nameInput.nativeElement.focus();
    }, 0);
  }
  onSubmit() {
    const form = this.signupForm.value;
    if (form.password === form.rePassword) {
      this.signupSubscr = this.auth
        .register(form.name, form.email, form.password)
        .subscribe(() => {
          this.router.navigateByUrl('/login');
        });
    }
  }

  ngOnDestroy() {
    this.signupSubscr?.unsubscribe();
  }
}
