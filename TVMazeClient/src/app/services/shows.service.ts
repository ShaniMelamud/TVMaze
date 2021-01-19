import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ShowModel } from '../models/show.model';

@Injectable({
    providedIn: 'root'
})
export class ShowsService {

    constructor(private http: HttpClient) { }

    public async GetShowsBySearchText(searchText: string): Promise<undefined> {
        try {
            const shows = await this.http.get<undefined>("https://localhost:44385/api/Shows" + "/" + searchText).toPromise();
            return shows;
        }
        catch (err) {
            console.log(err);
            return;
        }
    }
}
