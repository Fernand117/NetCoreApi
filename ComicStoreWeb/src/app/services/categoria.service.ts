import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";


@Injectable()
export class CategoriaService {

  private url = "http://localhost:58693/api/";

  constructor(private http: HttpClient){}

  getCategorias() {
    return this.http.get(`${this.url}Categoria`);
  }

  nuevaCategoria(datos: any) {
    return this.http.post(`${this.url}Categoria`, datos);
  }
}
