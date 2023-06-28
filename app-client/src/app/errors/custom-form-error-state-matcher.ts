import { FormControl, FormGroupDirective, NgForm } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';

export class CustomFormErrorStateMatcher implements ErrorStateMatcher {
  /**
   * isErrorState method checks if the form control is in an error state.
   * It returns true if the control is dirty and invalid, otherwise false.
   * @param control - The form control to check for error state.
   * @returns A boolean indicating if the control is in an error state.
   */
  isErrorState(
    control: FormControl | null,
  ): boolean {
    return !!(control?.dirty && control?.invalid);
  }
}
