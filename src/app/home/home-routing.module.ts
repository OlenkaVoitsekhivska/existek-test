import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoryViewComponent } from './components/category-view/category-view.component';
import { ProductsComponent } from './components/products/products.component';
import { HomeComponent } from './home.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',

    component: HomeComponent,
    children: [{ path: '', component: ProductsComponent }],
  },
  {
    path: ':category',
    component: HomeComponent,
    children: [{ path: '', component: CategoryViewComponent }],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule {}
