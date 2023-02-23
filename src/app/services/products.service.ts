import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { shareReplay } from 'rxjs';
import { ProductResp } from '../models/product.model';
import { environment } from 'src/environments/environment.prod';

@Injectable({
  providedIn: 'root',
})
export class ProductsService {
  currentPage = 1;

  broadcastLatestProducts = new BehaviorSubject<ProductResp>({
    Products: [],
    CurrentPage: 1,
    Pages: 0,
    Total: 0,
  });
  broadcastLatestProducts$ = this.broadcastLatestProducts.asObservable();

  searchString = '';

  buildUrl(endpoint = '') {
    return `${environment.API_URL}/Products/${endpoint}`;
  }

  constructor(private http: HttpClient) {}

  setSearchString(val: string) {
    this.searchString = val;
    this.getProducts(this.currentPage, val);
  }

  getProducts(page: number, searchQuery = this.searchString): void {
    const URL = this.buildUrl();
    let queryParams = new HttpParams().append('page', page);
    if (searchQuery) {
      queryParams = queryParams.append('searchQuery', searchQuery);
    }
    this.http
      .get<ProductResp>(URL, { params: queryParams })
      .pipe(shareReplay())
      .subscribe((res) => this.broadcastLatestProducts.next(res));
  }

  getProductsByCategory(
    page: number,
    category: string,
    searchString = this.searchString
  ): void {
    const URL = this.buildUrl(category);
    let queryParams = new HttpParams().append('page', page);
    if (searchString) {
      queryParams = queryParams.append('searchQuery', searchString);
    }

    this.http
      .get<ProductResp>(URL, {
        params: queryParams,
      })
      .subscribe((res) => this.broadcastLatestProducts.next(res));
  }
}
