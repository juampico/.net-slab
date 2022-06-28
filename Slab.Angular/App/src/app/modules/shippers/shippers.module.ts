import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ABMCComponent } from './abmc/abmc.component';
import { ShippersRoutingModule } from './shippers-routing.module';
import { MaterialModule } from '../material/material.module';
import { ShipperDeleteDialogComponent } from './dialogs/shipper-delete-dialog/shipper-delete-dialog.component';
import { ShipperDetailDialogComponent } from './dialogs/shipper-detail-dialog/shipper-detail-dialog.component';
import { ShipperUpdateFormDialogComponent } from './dialogs/shipper-update-form-dialog/shipper-update-form-dialog.component';
import { ShipperAddFormDialogComponent } from './dialogs/shipper-add-form-dialog/shipper-add-form-dialog.component';



@NgModule({
  declarations: [
    ABMCComponent,
    ShipperDeleteDialogComponent,
    ShipperDetailDialogComponent,
    ShipperUpdateFormDialogComponent,
    ShipperAddFormDialogComponent
  ],
  imports: [
    CommonModule,
    ShippersRoutingModule,
    MaterialModule
  ]
})
export class ShippersModule { }
