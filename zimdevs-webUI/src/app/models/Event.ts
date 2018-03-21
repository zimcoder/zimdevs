import { Time } from "@angular/common";
import { EventType } from "./EventType";

export class Event{
    eventId:number;
    eventName:string;
    eventVenue:string;
    eventDate:Date;
    eventStateTime:Time;
    eventEndTime:Time;
    eventType:EventType;
}