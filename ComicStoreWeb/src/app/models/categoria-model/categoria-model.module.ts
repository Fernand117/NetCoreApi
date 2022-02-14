import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class CategoriaModelModule {
  public idCategoria: number;
  public categoria: string;

  constructor() {
    this.idCategoria = 0;
    this.categoria = "";
  }
}
