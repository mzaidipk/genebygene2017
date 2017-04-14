import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SamplesRoutingModule } from './samples-routing.module';
import { SamplesComponent } from './components/samples.component';
import { SamplesService } from './samples.service';
import { UsersService } from './users.service';
import { FormsModule } from '@angular/forms';
import { AddEditSampleComponent } from './components/add-edit-sample/add-edit-sample.component';

@NgModule({
  imports: [
    CommonModule,
    SamplesRoutingModule,
    FormsModule
  ],
  declarations: [SamplesComponent, AddEditSampleComponent],
  providers: [
      SamplesService,
      UsersService
    ]
})
export class SamplesModule { }
