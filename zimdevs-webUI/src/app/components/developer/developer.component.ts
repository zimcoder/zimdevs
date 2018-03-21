import { Component, OnInit } from '@angular/core';
import {
  AngularFirestore,
  AngularFirestoreCollection,
  AngularFirestoreDocument
} from 'angularfire2/firestore';
import { Developer } from '../../models/Developer';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

@Component({
  selector: 'app-developer',
  templateUrl: './developer.component.html',
  styleUrls: ['./developer.component.css']
})
export class DeveloperComponent implements OnInit {

  devCollection: AngularFirestoreCollection<Developer>;
  devs: Observable<Developer[]>;

  constructor(private afs: AngularFirestore) { }

  ngOnInit() {
    this.devCollection = this.afs.collection('developers');
    this.devs = this.devCollection.valueChanges();
  }

}
