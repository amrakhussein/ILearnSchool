import { ErrorHandler, Injectable, NgZone } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root',
})
export class CustomErrorHandlerService implements ErrorHandler {
  constructor(private snackbar: MatSnackBar, private zone: NgZone) {}

  handleError(error: unknown): void {
    this.zone.run(() => {
      this.snackbar.open(
        'Unexpected error has occured. Try again later!',
        'Close',
        {
          duration: 4000, // 4 seconds
        }
      );
    });

    console.warn(`Error caught by Custom Error Handler: ${error}`);
  }
}
