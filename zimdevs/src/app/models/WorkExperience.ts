import { Skill } from "./Skill";

export class WorkExperience{

        experienceId:number;
        employerName:string;
        contactPerson:string;
        contactNumber:string;
        contactEmail:string;
        skills:Skill[];
        startDate:Date;
        endDate:Date;
        reasonForLeaving:string
      
}