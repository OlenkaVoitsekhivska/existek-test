import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';
import { FormsModule } from '@angular/forms';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { HeaderComponent } from './components/header/header.component';
import { ProductsComponent } from './components/products/products.component';
import { ProductComponent } from './components/product/product.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { CategoryViewComponent } from './components/category-view/category-view.component';

@NgModule({
  declarations: [
    HomeComponent,
    HeaderComponent,
    ProductsComponent,
    ProductComponent,
    SidebarComponent,
    CategoryViewComponent,
  ],
  imports: [CommonModule, HomeRoutingModule, SharedModule, FormsModule],
  exports: [HomeComponent, CategoryViewComponent],
})
export class HomeModule {}
