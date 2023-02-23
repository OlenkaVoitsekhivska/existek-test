import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { tap, Observable, map } from 'rxjs';
import { environment } from 'src/environments/environment.prod';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private http: HttpClient) {}

  buildUrl(endpoint: string) {
    return `${environment.API_URL}/User/${endpoint}`;
  }

  login(email: string, password: string) {
    const URL = this.buildUrl('login');
    return this.http
      .post<{ Token: string }>(URL, {
        email,
        password,
      })
      .pipe(
        map((val) => {
          if (!val.Token) {
            throw new Error('Wrong email or password!');
          }
          return val;
        }),
        tap((res) => {
          this.setSession(res.Token);
        })
      );
  }

  register(
    name: any,
    email: any,
    password: any
  ): Observable<{ passwordHash: string; email: string }> {
    const URL = this.buildUrl('signup');
    return this.http
      .post<{ passwordHash: string; email: string }>(URL, {
        name,
        email,
        password,
      })
      .pipe(tap((res) => console.log(res)));
  }

  private setSession(authResult: string) {
    localStorage.setItem('token', JSON.stringify(authResult));
  }

  logout() {
    localStorage.removeItem('token');
  }
}
