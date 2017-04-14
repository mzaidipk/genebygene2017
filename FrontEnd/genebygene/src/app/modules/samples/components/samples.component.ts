import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SamplesService } from '../samples.service';
import { Samples } from '../models/samples';

@Component({
  selector: 'app-samples',
  templateUrl: './samples.component.html',
  styleUrls: ['./samples.component.scss']
})
export class SamplesComponent implements OnInit {

  constructor(private samplesService: SamplesService, private router: Router) { }
  public samples: Samples[] = [];
  public nameSearch: string;
  public statusId: number;
  getSamples(): void {
    this.samplesService.getAll()
      .then(r => {
        this.samples = r;
        console.log(r);
      });
  }
  getSamplesbyName(): void {
    this.samplesService.getSamplesByName(this.nameSearch)
      .then(r => {
        this.samples = r;
        console.log(r);
      });
  }
  getSamplesbyStatus(): void {
    this.samplesService.getSamplesbyStatus(this.statusId)
      .then(r => {
        this.samples = r;
        console.log(r);
      });
  }
  ngOnInit() {
    this.getSamples();
  }

}
