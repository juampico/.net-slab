import { Component, Inject, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ShippersService } from 'src/app/modules/api-rest/services/shippers.service';

export interface ShipperDialogData{
  id: number,
  name: string,
  phone: string
}

@Component({
  selector: 'app-shipper-update-form-dialog',
  templateUrl: './shipper-update-form-dialog.component.html',
  styleUrls: ['./shipper-update-form-dialog.component.scss']
})
export class ShipperUpdateFormDialogComponent implements OnInit {

  form: FormGroup = this.formBuilder.group({
    name: [this.data.name, [Validators.maxLength(40), Validators.required]],
    phone: [this.data.phone, [Validators.maxLength(24)]]
  });
  updating = false;

  constructor(
		private readonly formBuilder: FormBuilder,
		@Inject(MAT_DIALOG_DATA) public readonly data: ShipperDialogData,
		private readonly dialogRef: MatDialogRef<ShipperUpdateFormDialogComponent>,
		private readonly shippersService: ShippersService,
		private readonly snackBar: MatSnackBar,
  ) { }

  ngOnInit(): void {

  }

  editShipper(): void {
    if (this.form.valid){
      this.updating = true;
      let bodyShipper ={
        CompanyName: this.form.value.name,
        Phone: this.form.value.phone
      };
      console.log(this.form)
      this.shippersService.updateShipper(this.data.id, bodyShipper).subscribe(
        (data) => {
          this.updating = false;
          this.snackBar.open('Shipper: ' + this.data.id + ' edited', '', { duration: 3000 })
          this.dialogRef.close();
        },
        (error) => {
          this.updating = false;
          this.snackBar.open('Error editing shipper' + error, 'Cerrar', { duration: 3000 })
        }
      );
    }
  }

}
