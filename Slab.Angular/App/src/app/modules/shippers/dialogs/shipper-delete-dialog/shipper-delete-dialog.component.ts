import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ShippersService } from 'src/app/modules/api-rest/services/shippers.service';
//import { TaskService } from 'src/app/modules/api-rest/services/task.service';
//import { TaskCoreService } from 'src/app/modules/core/services/task-core.service';


export interface TaskDeleteDialogData {
	id: number,
  name: string
}



@Component({
  selector: 'app-shipper-delete-dialog',
  templateUrl: './shipper-delete-dialog.component.html',
  styleUrls: ['./shipper-delete-dialog.component.scss']
})
export class ShipperDeleteDialogComponent implements OnInit {

  deleting: boolean = false;
  constructor(
		@Inject(MAT_DIALOG_DATA) public readonly data: TaskDeleteDialogData,
		private readonly dialogRef: MatDialogRef<ShipperDeleteDialogComponent>,
		private readonly snackBar: MatSnackBar,
    private readonly shippersService: ShippersService
) { }

  ngOnInit(): void {
  }

  deleteShipper(): void{
    this.deleting = true;
    this.shippersService.deleteShippers(this.data.id).subscribe(
      (data) => {
        this.deleting = false;
        this.snackBar.open('Shipper: ' + this.data.id + ' deleted', '', { duration: 3000 })
        this.dialogRef.close();
      },
      (error) => {
        console.log(error);
        this.deleting = false;
        this.snackBar.open('Error deleting shipper ' + this.data.id + ': ' + error.status, '', { duration: 3000 })
      }
    )
  }

}
