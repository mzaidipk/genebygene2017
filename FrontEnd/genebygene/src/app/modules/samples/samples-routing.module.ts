import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SamplesComponent } from './components/samples.component';
import { AddEditSampleComponent } from './components/add-edit-sample/add-edit-sample.component';

const routes: Routes = [
  { path: '', component:SamplesComponent },
  { path: 'samples/add', component:AddEditSampleComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
  providers: []
})
export class SamplesRoutingModule { }
