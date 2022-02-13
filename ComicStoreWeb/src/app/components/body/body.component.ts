import { Component, OnInit } from '@angular/core';
import { CategoriaService } from '../../services/categoria.service';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html'
})

export class BodyComponent implements OnInit{

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
