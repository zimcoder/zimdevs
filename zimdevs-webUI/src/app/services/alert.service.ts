import { Injectable } from "@angular/core";
import { MatSnackBar } from "@angular/material";

@Injectable()
export class AlertService {

  constructor(private snackBar: MatSnackBar) { }

  success(message: string) {
    this.snackBar.open("Success: " + message, "Dismiss", {
      duration: 7500
    });
  }

  error(message: string) {
    this.snackBar.open("Error: " + message, "Dismiss", {
      duration: 7500
    });
  }
}
