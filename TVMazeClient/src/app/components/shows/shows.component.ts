import { ShowModel } from './../../models/show.model';
import { ShowsService } from './../../services/shows.service';
import { Component } from '@angular/core';

@Component({
    selector: 'app-shows',
    templateUrl: './shows.component.html',
    styleUrls: ['./shows.component.css']
})
export class ShowsComponent  {

public shows: ShowModel;
public searchText: string;

    constructor(private showsService: ShowsService) { }

    

    public async search() {
        try {
           this.shows = await this.showsService.GetShowsBySearchText(this.searchText);
        }
        catch (err) {
            console.log("Error: " + err.message);
        }
    }

    onKey(event: any) { 
      this.searchText = event.target.value;
    }
}
