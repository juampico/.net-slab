import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';


export interface ShipperDetailData {
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
    @Inject(MAT_DIALOG_DATA) public readonly data: ShipperDetailData) { }

  ngOnInit(): void {
  }


}
