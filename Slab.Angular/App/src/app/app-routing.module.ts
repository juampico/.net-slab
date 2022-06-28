import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: '/shippers/abmc', pathMatch: 'full' }
  ,{ 
    path: 'shippers', loadChildren: () => import('./modules/shippers/shippers.module').then(m => m.ShippersModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
