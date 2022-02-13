import { Component, OnInit } from '@angular/core';
import { CategoriaService } from '../../services/categoria.service';

@Component({
  selector: 'app-formcategoria',
  templateUrl: './formcategoria.component.html',
  styleUrls: ['./formcategoria.component.scss']
})
export class FormcategoriaComponent implements OnInit {

  private categorias: any[] = [];
  private formData: FormData = new FormData();

  public result: any;
  public getResult: any;

  constructor(private service:CategoriaService){}

  ngOnInit(): void {
    this.service.getCategorias().subscribe(
      res => {
        this.result = res;
        this.getResult = this.result['data'];

        console.log(this.result['data']);
      }, err => {
        console.log(err);
      }
    );
  }

}
