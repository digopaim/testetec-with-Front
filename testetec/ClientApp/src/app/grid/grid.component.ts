import { Component, OnInit, ViewChild } from '@angular/core';
// import { OwlOptions } from 'ngx-owl-carousel-o';
import { GridService } from './services/grid.service';
import { BehaviorSubject } from 'rxjs';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { Router } from '@angular/router';
@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.css']
})
export class GridComponent implements OnInit {

  constructor(
    public gridService: GridService,
    protected router: Router
  ) { }
  SlideOptions = { items: 1, dots: true, nav: true };
  CarouselOptions = { items: 3, dots: true, nav: true };  
  ricksList: any;
  customOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    pullDrag: false,
    dots: false,
    navSpeed: 700,
    navText: ['Anterior', 'Próximo'],
    responsive: {
      0: {
        items: 1 
      },
      400: {
        items: 2
      },
      740: {
        items: 3
      },
      940: {
        items: 4
      }
    },
    nav: true
  }
  ngOnInit() {
    this.gridService.get().subscribe(res => {
      
      this.ricksList =  new BehaviorSubject<any>(res);
      console.log(this.ricksList);
    });
  }
  GoToRick(item){ 
    console.log(item);
    this.router.navigate(["/rickDetail/" + item.id]);
  }
}
