import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';


export interface ShipperDetailData{
  id: number,
  name: string,
  phone: string
}

@Component({
  selector: 'app-shipper-detail-dialog',
  templateUrl: './shipper-detail-dialog.component.html',
  styleUrls: ['./shipper-detail-dialog.component.scss']
})
export class ShipperDetailDialogComponent implements OnInit {

  shipper: any;

  constructor(
		@Inject(MAT_DIALOG_DATA) public readonly data: ShipperDetailData,
		private readonly dialogRef: MatDialogRef<ShipperDetailDialogComponent>,
		//private readonly taskService: TaskService,
		private readonly snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }


}
