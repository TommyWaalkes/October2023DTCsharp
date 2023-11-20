import { Component } from '@angular/core';
import { MovieAPIService } from './movie-api.service';
import { SearchResults } from './search-results';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title:string ="";
  result:SearchResults = {} as SearchResults;
  constructor(private movieAPI: MovieAPIService){
    this.title = "Air Bud";
    this.searchByTitle();
  }

  searchByTitle(){
    //We give subscribe a function to run once the API response comes back 
    //We pass in the function as a parameter, this is called an aynomous function 
    //AKA a function made completely in line unattached to any class
    this.movieAPI.getMovieSearchResults(this.title).subscribe(
      (response)=>{
        //This is use for checking whether the API calls worked or if nothing was found
        console.log(response);
        this.result = response;
      }
    )
  }
}
