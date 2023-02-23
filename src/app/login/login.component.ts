import {
  AfterViewInit,
  ChangeDetectionStrategy,
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
  selector: 'app-login',
  templateUrl: './login.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LoginComponent implements AfterViewInit, OnDestroy {
  @ViewChild('emailInput', { static: true }) emailInput!: ElementRef;
  loginForm = this.fb.group({
    email: ['', Validators.required],
    password: ['', Validators.required],
  });

  loginSubscr!: Subscription;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private router: Router
  ) {}

  get email() {
    return this.loginForm.get('email');
  }

  get password() {
    return this.loginForm.get('password');
  }
  ngAfterViewInit() {
    setTimeout(() => {
      this.emailInput.nativeElement.focus();
    }, 0);
  }

  onSubmit(): void {
    const form = this.loginForm.value;
    if (form.email?.trim() && form.password?.trim()) {
      this.loginSubscr = this.authService
        .login(form.email, form.password)
        .subscribe(() => {
          this.router.navigate(['/home']);
        });
    }
  }

  ngOnDestroy(): void {
    this.loginSubscr?.unsubscribe();
  }
}
