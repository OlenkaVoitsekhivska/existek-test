import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { PageEvent } from '@angular/material/paginator';
import { Observable } from 'rxjs';
import { ProductResp } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProductsComponent implements OnInit {
  PRODUCT_RES!: Observable<ProductResp>;
  currentPage = 1;

  constructor(private prodService: ProductsService) {}

  ngOnInit() {
    this.prodService.getProducts(1);
    this.PRODUCT_RES = this.prodService.broadcastLatestProducts$;
  }

  onPageChange(event: PageEvent) {
    this.currentPage = event.pageIndex + 1;
    this.prodService.getProducts(this.currentPage);
  }
}
