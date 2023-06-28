import { NgModule } from '@angular/core';

import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatSelectModule } from '@angular/material/select';
import { MatToolbarModule } from '@angular/material/toolbar';

const materialFormUIs = [
  MatToolbarModule,
  MatButtonModule,
  MatSelectModule,
  MatCardModule,
];

@NgModule({
  exports: [materialFormUIs],
})
export class MaterialFormStylesModule {}
