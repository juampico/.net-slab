import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatDialogModule } from '@angular/material/dialog';
import { MatTableModule } from '@angular/material/table';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';





@NgModule({
	declarations: [],
	imports: [
		CommonModule,
		MatToolbarModule,
		MatSnackBarModule,
		MatCardModule,
		MatFormFieldModule,
		ReactiveFormsModule,
		MatInputModule,
		MatToolbarModule,
		MatButtonModule,
		MatIconModule,
		MatListModule,
		MatProgressBarModule,
		MatDialogModule,
		MatTableModule,
		MatProgressSpinnerModule
	],
	exports: [
		MatSnackBarModule,
		CommonModule,
		MatToolbarModule,
		MatCardModule,
		MatFormFieldModule,
		ReactiveFormsModule,
		MatInputModule,
		MatToolbarModule,
		MatButtonModule,
		MatIconModule,
		MatListModule,
		MatProgressBarModule,
		MatDialogModule,
		MatTableModule,
		MatProgressSpinnerModule
	]
})
export class MaterialModule {
}
