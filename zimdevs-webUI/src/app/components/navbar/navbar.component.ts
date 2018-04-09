import { Component, OnInit } from '@angular/core';
import { FormsModule, ReactiveFormsModule,FormControl, Validators} from '@angular/forms';
@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  emailFormControl = new FormControl(Validators.required);
  constructor() { }

  ngOnInit() {
  }

  isAuthenticated()
  {
    return false;
  }
}
