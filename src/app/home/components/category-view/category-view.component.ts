import {
  ChangeDetectionStrategy,
  Component,
  OnDestroy,
  OnInit,
  ViewChild,
} from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { ActivatedRoute, Router } from '@angular/router';
import { map, Observable, Subscription, tap } from 'rxjs';
import { ProductResp } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-category-view',
  templateUrl: '../products/products.component.html',
  styleUrls: ['../products/products.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class CategoryViewComponent implements OnInit, OnDestroy {
  PRODUCT_RES!: Observable<ProductResp>;
  routeSubscr!: Subscription;
  currentPage = 1;
  category!: string;

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  constructor(
    private prodService: ProductsService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.currentPage = 1;
    this.PRODUCT_RES = this.prodService.broadcastLatestProducts$;
    this.routeSubscr = this.route.params
      .pipe(
        tap((params) => (this.category = params['category'])),
        map((param) =>
          this.prodService.getProductsByCategory(1, param['category'])
        )
      )
      .subscribe();
  }

  onPageChange(event: PageEvent) {
    this.currentPage = event.pageIndex + 1;
    this.prodService.getProductsByCategory(this.currentPage, this.category);
  }
  ngOnDestroy(): void {
    this.routeSubscr.unsubscribe();
  }
}
