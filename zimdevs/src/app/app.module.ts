//Angular Modules
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

//AngularFire2 Modules
import { AngularFireModule } from 'angularfire2';
import { AngularFirestoreModule, AngularFirestore } from 'angularfire2/firestore';

//Custom Modules
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { AppRoutingModule } from './app-routing.module';

//Components
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { LoginComponent } from './components/login/login.component';
import { DeveloperComponent } from './components/developer/developer.component';
import { UsertableComponent } from './components/usertable/usertable.component';
import { UserService } from './services/user.service';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { BlogComponent } from './components/blog/blog.component';
import { JobComponent } from './components/job/job.component';
import { MaterialModule } from './modules/material.module';
import { firebaseConfig } from './configurations/app.firebaseConfig';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavbarComponent,
    LoginComponent,
    DeveloperComponent,
    UsertableComponent,
    PageNotFoundComponent,
    BlogComponent,
    JobComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    MaterialModule,
    FormsModule,

    AngularFireModule.initializeApp(firebaseConfig),
    AngularFirestoreModule ,
    
    MDBBootstrapModule.forRoot()
  ],
  schemas: [NO_ERRORS_SCHEMA],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
