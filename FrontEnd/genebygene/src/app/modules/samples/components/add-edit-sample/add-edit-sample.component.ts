import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SamplesService } from '../../samples.service';
import { UsersService } from '../../users.service';
import { Samples } from '../../models/samples';
import { Users } from '../../models/users';

@Component({
  selector: 'app-add-edit-sample',
  templateUrl: './add-edit-sample.component.html',
  styleUrls: ['./add-edit-sample.component.scss']
})
export class AddEditSampleComponent implements OnInit {
  public sample: Samples = new Samples();
  public message: string = "Enter New Sample To See Message";
  public isSucceed: boolean = false;
  public isNewSample: boolean = true;
  public users: Users[] = [];

  constructor(private samplesService: SamplesService, private usersService: UsersService, private router: Router) { }

  ngOnInit() {
    this.sample.createdAt = new Date();
    this.sample.barcode = '12344';
    this.sample.firstName = 'John';
    this.sample.lastName = 'Doe';
    this.sample.sampleId = -1;
    this.sample.createdBy = 5;
    
      this.usersService.getAll()
        .then(r => {
          this.users = r;
          console.log(r);
        });
  }

  save(): void {
    console.log(this.sample);
    this.samplesService.create(this.sample)
      .then(r => {
        console.log(r);
        this.isNewSample = false;
        if(r.ok)
        {
          this.isSucceed = true;
        }
        else
        {
          this.isSucceed = false;
        }
        this.message = r.toString() + '  "message from Server": ' + r.text();
      });
  }

}
