import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface ShipperDTO {
	ID: number,
	CompanyName: string,
	Phone: string
}

export interface ShipperRequestDTO {
	CompanyName: string,
	Phone: string
}


@Injectable({
	providedIn: 'root'
})
export class ShippersService {


	url = 'https://localhost:44305/api/Shippers/';


	constructor(
		private readonly http: HttpClient,
	) { }


	listShippers(): Observable<any> {

		return this.http.get<any>(
			this.url,
			{
				headers: {
					'Content-Type': 'application/json'
				}
			});
	}


	getShipper(shipper: string): Observable<ShipperDTO> {
		return this.http.get<ShipperDTO>(
			this.url + '/' + shipper, {
			headers: {
				'Content-Type': 'application/json'
			}
		});
	}


	createShipper(shipper: ShipperRequestDTO): Observable<any> {
		return this.http.post<any>(
			this.url, shipper, {
			headers: {
				'Content-Type': 'application/json'
			}
		}
		)
	}

	updateShipper(id: number, shipper: ShipperRequestDTO): Observable<any> {
		return this.http.post<any>(
			this.url + id, shipper, {
			headers: {
				'Content-Type': 'application/json'
			}
		}
		)
	}


	deleteShippers(shipper: number): Observable<any> {
		return this.http.delete(
			this.url + '/' + shipper, {
			headers: {
				'Content-Type': 'application/json'
			}
		}
		)
	}

}
