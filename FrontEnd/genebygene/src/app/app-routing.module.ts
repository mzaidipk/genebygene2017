import { NgModule }             from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';


export const routes: Routes = [
  { path: '', loadChildren:'./modules/samples/samples.module#SamplesModule' },
  //{ path: '', component: AppComponent },
];
//alsohere
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}