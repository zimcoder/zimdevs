import { SkillLevel } from "./SkillLevel";

export class Skill {
    skillID: number;
    developerId: number;
    skillName: string;
    skillLevel: SkillLevel;
    yearsOfExperince: number;
    dateLastUsed: Date;
}