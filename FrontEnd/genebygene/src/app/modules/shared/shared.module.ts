import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpService } from './util/authhttp.service';
import { RepoService } from './util/repo.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [],
  providers: [HttpService, RepoService]
})
export class SharedModule { }
