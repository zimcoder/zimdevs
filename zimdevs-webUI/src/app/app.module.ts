//Angular Modules
import { BrowserModule } from "@angular/platform-browser";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { NgModule, NO_ERRORS_SCHEMA } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule,ReactiveFormsModule } from "@angular/forms";

//Custom Modules
import { MDBBootstrapModule } from "angular-bootstrap-md";
import { AppRoutingModule } from "./app-routing.module";

//Components
import { AppComponent } from "./app.component";
import { HomeComponent } from "./components/home/home.component";
import { NavbarComponent } from "./components/navbar/navbar.component";
import { LoginComponent } from "./components/login/login.component";
import { DeveloperComponent } from "./components/developer/developer.component";
import { UsertableComponent } from "./components/usertable/usertable.component";
import { PageNotFoundComponent } from "./components/page-not-found/page-not-found.component";
import { BlogComponent } from "./components/blog/blog.component";
import { JobComponent } from "./components/job/job.component";
import { MaterialModule } from "./modules/material.module";
import { firebaseConfig } from "./configurations/app.firebaseConfig";
import { EventComponent } from "./components/event/event.component";
import { RegisterComponent } from "./components/register/register.component";
import { DeveloperService } from "./services/developer.service";
import { MessageBoardComponent } from './message-board/message-board.component';


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
    JobComponent,
    EventComponent,
    RegisterComponent,
    MessageBoardComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    MaterialModule,
    FormsModule, 
    ReactiveFormsModule,
   
    MDBBootstrapModule.forRoot()
  ],
  schemas: [NO_ERRORS_SCHEMA],
  providers: [DeveloperService],
  bootstrap: [AppComponent]
})
export class AppModule { }
