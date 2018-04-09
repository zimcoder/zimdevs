import { Component, OnInit } from '@angular/core';
import { Developer } from '../../models/Developer';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { DeveloperService } from '../../services/developer.service';

@Component({
  selector: 'app-developer',
  templateUrl: './developer.component.html',
  styleUrls: ['./developer.component.css']
})
export class DeveloperComponent implements OnInit {


  developers:Developer[];

  constructor(private devService: DeveloperService) { }

  ngOnInit() {
    this.devService.getDevelopers().subscribe(developers => this.developers = developers);
  //  console.log("DEVELOPERS",this.developers);
  }

}
