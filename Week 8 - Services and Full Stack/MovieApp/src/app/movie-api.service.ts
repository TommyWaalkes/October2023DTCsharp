import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SearchResults } from './search-results';
import { MovieDetailsDB } from './movie-details';

@Injectable({
  providedIn: 'root'
})
export class MovieAPIService {
  apiKey:string = "62398519";
  baseUrl:string =`https://www.omdbapi.com/?apikey=${this.apiKey}&`;
//Steps to make an API Service 
//1) Generate the service 
//2) Create the model, most easily done via Quicktype 
//3) Inject the HTTP service and import it in App.Module
//4) Write a method for each end point you wish to call (you don't need to grab all endpoints)
  
//Services can inject other services <-- sounds complicated, but gives us a lot of 
//Conviences
constructor(private http:HttpClient) { }

  getMovieSearchResults(title:string) : Observable<SearchResults>{
    //Angular APIs generally are only one or two lines, it automates what we had to do manually in C# 
    
    //What is an Observable? API calls in Javascript/Angular are async, meaning it runs independent of the rest of the app. 
    //We want to return an observable since we can, in our component, wait for the API call to finish and then react to it. 
    //We create a listener in the component that waits for the response to come back from the API, error or no
    //The method we'll use is called subscribe()
    return this.http.get<SearchResults>(this.baseUrl+"s="+title);
  }

  getMovieDetailsById(id:string) : Observable<MovieDetailsDB>{
    return this.http.get<MovieDetailsDB>(this.baseUrl+"i="+id);
  }
}
