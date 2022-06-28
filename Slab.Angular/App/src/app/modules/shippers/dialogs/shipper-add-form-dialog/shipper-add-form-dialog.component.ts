import { Component, Inject, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ShippersService } from 'src/app/modules/api-rest/services/shippers.service';


@Component({
  selector: 'app-shipper-add-form-dialog',
  templateUrl: './shipper-add-form-dialog.component.html',
  styleUrls: ['./shipper-add-form-dialog.component.scss']
})
export class ShipperAddFormDialogComponent implements OnInit {

  form: FormGroup = this.formBuilder.group({
    name: [null, [Validators.maxLength(40), Validators.required]],
    phone: [null, [Validators.maxLength(24)]]
  });
  creating = false;

  constructor(
    private readonly formBuilder: FormBuilder,
    private readonly dialogRef: MatDialogRef<ShipperAddFormDialogComponent>,
    private readonly shippersService: ShippersService,
    private readonly snackBar: MatSnackBar,
  ) { }

  ngOnInit(): void {

  }

  addShipper(): void {
    if (this.form.valid) {
      this.creating = true;
      let bodyShipper = {
        CompanyName: this.form.value.name,
        Phone: this.form.value.phone
      };
      this.shippersService.createShipper(bodyShipper).subscribe(
        (data) => {
          this.creating = false;
          this.snackBar.open('Shipper crated', '', { duration: 3000 })
          this.dialogRef.close();
        },
        (error) => {
          this.creating = false;
          this.snackBar.open('Error creating shipper' + error, 'Cerrar', { duration: 3000 })
        }
      );
    }
  }

}
