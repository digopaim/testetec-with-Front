import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GridService } from '../grid/services/grid.service';
import { Rick, Dimensao } from '../grid/models/rick.model';
import { BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-rick-details',
  templateUrl: './rick-details.component.html',
  styleUrls: ['./rick-details.component.css']
})
export class RickDetailsComponent implements OnInit {

  nomeDimensao : string;
  constructor( public route: ActivatedRoute, public gridService: GridService) { }
  rick =  new Rick;

  ngOnInit() {
    this.rick.dimensao = new Dimensao();
    this.gridService.getById(this.route.snapshot.params['id']).subscribe(res => {
      this.rick = res;
    });
  }

}
