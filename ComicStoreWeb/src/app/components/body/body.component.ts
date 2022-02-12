import { Component, OnInit } from '@angular/core';
import { CategoriaService } from '../../services/categoria.service';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html'
})

export class BodyComponent implements OnInit{

  private categorias: any[] = [];
  private formData: FormData = new FormData();

  constructor(private service:CategoriaService){}

  ngOnInit(): void {

  }
}
