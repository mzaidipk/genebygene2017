
import { Injectable } from '@angular/core';
import { Response } from "@angular/http";

import { RepoService, IDataService } from "../shared/util/repo.service";
import { Users } from './models/users';
@Injectable()
export class UsersService implements IDataService<Users>{

  constructor(private repo: RepoService) { }
  private UsersUrl = 'api/Users/';  // URL to web api
  public async getAll() {
    return this.repo.get<Users>(this.UsersUrl);
  }

  public async create(user: Users) {
    return this.repo.post<Users>(this.UsersUrl, user);
  }
}
