import { Component, OnInit } from '@angular/core';
import { CategoriaService } from '../../services/categoria.service';
import { CategoriaModelModule } from '../../models/categoria-model/categoria-model.module';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.scss']
})

export class BodyComponent implements OnInit{

  public categoria: CategoriaModelModule = new CategoriaModelModule();

  public result: any;
  public getResult: any[] = [];

  public categoriaID: number = 0;
  public nombreCategoria: string = "";

  constructor(private service:CategoriaService){
  }

  ngOnInit(): void {
    this.cargarCategorias(0);
  }

  cargarCategorias(id: number) {
    this.categoriaID = 0;
    this.nombreCategoria = "";
    if (id > 0) {
      this.service.buscarCategoria(id).subscribe(
        res => {
          this.result = res;
          this.getResult = [];
          this.categoriaID = this.result['data']['idCategoria'];
          this.nombreCategoria = this.result['data']['categoria'];
        }
      );
      return;
    } else {
      this.service.getCategorias().subscribe(
        res => {
          this.result = res;
          this.getResult = this.result['data'];
          console.log(this.getResult)
        }, err => {
          console.log(err);
        }
      );
      return;
    }
  }

  guardarCategoria() {
    const data = {
      "IdCategoria" : this.categoria.idCategoria,
      "Nombre" : this.categoria.categoria
    }

    if (this.categoria.idCategoria > 0) {
      this.service.editarCategoria(data).subscribe(
        res => {
          this.cargarCategorias(0);
        }
      );
      return;
    } else {
      this.service.nuevaCategoria(data).subscribe(
        res => {
          this.cargarCategorias(0);
        }
      );
      return;
    }
  }

  editarCategoria(id: any, nombre: any) {
    this.categoria.idCategoria = id;
    this.categoria.categoria = nombre;
  }

  buscarCategoria(id: number) {
    this.cargarCategorias(id);
  }

  eliminarCategoria(id: number) {
    this.service.eliminarCategoria(id).subscribe(
      res => {
        this.cargarCategorias(0);
      }
    );
  }
}
