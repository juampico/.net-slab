import {Component, OnInit} from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatDialog } from '@angular/material/dialog';
import { Title } from '@angular/platform-browser';
import { ShipperUpdateFormDialogComponent } from '../dialogs/shipper-update-form-dialog/shipper-update-form-dialog.component';
import { ShipperDetailDialogComponent } from '../dialogs/shipper-detail-dialog/shipper-detail-dialog.component';
import { ShipperDeleteDialogComponent } from '../dialogs/shipper-delete-dialog/shipper-delete-dialog.component';
import { ShippersService } from '../../api-rest/services/shippers.service';
import { ShipperAddFormDialogComponent } from '../dialogs/shipper-add-form-dialog/shipper-add-form-dialog.component';






@Component({
  selector: 'app-abmc',
  templateUrl: './abmc.component.html',
  styleUrls: ['./abmc.component.scss']
})
export class ABMCComponent implements OnInit {

  shippers = []
  displayedColumns: string[] = ['ShipperID', 'CompanyName', 'Phone', 'Info','Edit', 'Remove'];
  columnsToDisplay = ['ShipperID', 'CompanyName', 'Phone', 'Info', 'Edit', 'Remove'];
  constructor(
		private readonly snackBar: MatSnackBar,
    private readonly shippersService: ShippersService,
		private readonly dialog: MatDialog,
    private readonly title: Title
) { }

  ngOnInit(): void {
    this.listShippers();
    this.title.setTitle("Shippers")
  }


  listShippers(){
    this.shippersService.listShippers().subscribe( (data) => {
      this.shippers = data;
    })
  }

  addShipper(): void {
    this.dialog.open(ShipperAddFormDialogComponent).afterClosed().subscribe( () => this.listShippers());
	}


  detailShipper(id: number, shipper: string, phone: string): void {
    this.dialog.open(ShipperDetailDialogComponent, {
      data: {
        id: id,
        name: shipper,
        phone: phone
      }
    })
	}


  editShipper(id: number, shipper: string, phone: string): void {
    //Podria ser haciendo un get con los details pero como la tabla no tiene mas datos no lo vi necesario en este caso
		this.dialog.open(ShipperUpdateFormDialogComponent,
			{
				data: {
          id: id,
					name: shipper,
          phone: phone
				}
			}).afterClosed().subscribe( () => this.listShippers());
	}

  deleteShipper(id: number,shipper: string): void {
		this.dialog.open(ShipperDeleteDialogComponent,
			{
				data: {
          id: id,
					name: shipper
				}
			}).afterClosed().subscribe( () => this.listShippers());
	}



}
