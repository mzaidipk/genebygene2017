import { Injectable } from '@angular/core';
import { Response } from "@angular/http";

import { RepoService, IDataService } from "../shared/util/repo.service";
import { Samples } from './models/samples';
@Injectable()
export class SamplesService implements IDataService<Samples>{

  constructor(private repo: RepoService) { }
  private SamplesUrl = 'api/Samples/';  // URL to web api
  public async getAll() {
    return this.repo.get<Samples>(this.SamplesUrl + 'GetAllSamplesWithName');
  }

  public async getSamplesByName(name: string) {
    return this.repo.get<Samples>(this.SamplesUrl + 'user/' + name);
  }

  public async getSamplesbyStatus(statusId: number) {
    return this.repo.get<Samples>(this.SamplesUrl + 'status/' + statusId);
  }
  
  public async create(sample: Samples) {
    return this.repo.post<Samples>(this.SamplesUrl, sample);
  }
}
