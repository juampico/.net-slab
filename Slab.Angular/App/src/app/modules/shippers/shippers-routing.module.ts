import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ABMCComponent } from './abmc/abmc.component';


const routes: Routes = [
	{ path: 'abmc', component: ABMCComponent },
];

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule]
})
export class ShippersRoutingModule { }
