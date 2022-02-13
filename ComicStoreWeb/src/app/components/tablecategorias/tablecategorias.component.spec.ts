import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TablecategoriasComponent } from './tablecategorias.component';

describe('TablecategoriasComponent', () => {
  let component: TablecategoriasComponent;
  let fixture: ComponentFixture<TablecategoriasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TablecategoriasComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TablecategoriasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
