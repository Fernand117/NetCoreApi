import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class CategoriaService {

  private url = "http://localhost:58693/api/Categoria";

  constructor(private http: HttpClient){}

  getCategorias() {
    return this.http.get(`${this.url}`);
  }

  buscarCategoria(id: number) {
    return this.http.get(`${this.url}/${id}`);
  }

  nuevaCategoria(datos: any) {
    return this.http.post(`${this.url}`, datos);
  }

  editarCategoria(datos: any) {
    return this.http.put(`${this.url}`, datos);
  }

  eliminarCategoria(id: number) {
    return this.http.delete(`${this.url}/${id}`);
  }
}
