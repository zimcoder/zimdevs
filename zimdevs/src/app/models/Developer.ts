import { Gender } from "./Gender";
import { WorkExperience } from "./workExperience";

export class Developer{
    
    firstname:string;
    lastname:string;
    emailAddress:string;
    dateOfBirth:Date;
    registrationDate:Date;
    gender:Gender;
    isActive:boolean;
    isLoggedIn:boolean;
    workHistory:WorkExperience[]

}