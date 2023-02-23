export interface Product {
  Id: number;
  Title: string;
  Price: number;
  Image: string;
  Brand: string;
  Category: string;
}

export interface ProductResp {
  Products: Product[];
  CurrentPage: number;
  Pages: number;
  Total: number;
}
