import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { map, skipWhile, Subscription, tap } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit, OnDestroy {
  searchForm!: FormGroup;
  category!: string | null;
  routeSubscr!: Subscription;
  formValuesSubscr!: Subscription;
  constructor(
    private authService: AuthService,
    private router: Router,
    private activatedRoute: ActivatedRoute,
    private fb: FormBuilder,
    private prodService: ProductsService
  ) {
    this.searchForm = this.fb.group({
      search: [''],
    });
  }

  ngOnInit() {
    this.routeSubscr = this.activatedRoute.params
      .pipe(skipWhile((val) => !val['category']))
      .subscribe((paramObj) => {
        this.category = paramObj['category'];
      });
  }
  logout() {
    this.authService.logout();
    this.router.navigateByUrl('/login');
  }

  updateSearchString() {
    this.formValuesSubscr = this.searchForm.valueChanges
      .pipe(
        tap((val) => {
          this.prodService.setSearchString(val.search.trim());
        }),
        map((val) => {
          const searchStr = val.search.trim();
          if (this.category) {
            return this.prodService.getProductsByCategory(
              1,
              this.category,
              searchStr
            );
          }
          return this.prodService.getProducts(1, searchStr);
        })
      )
      .subscribe();
  }
  ngOnDestroy(): void {
    this.routeSubscr?.unsubscribe();
    this.formValuesSubscr?.unsubscribe();
  }
}
