import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieDetails } from './movie-details';

@Injectable({
  providedIn: 'root'
})
export class OurMovieAPIService {

  baseUrl:string = "https://localhost:7116/api/MovieDetails";
  constructor(private http:HttpClient) { }

  getAllMovieDetails():Observable<MovieDetails[]>{
    return this.http.get<MovieDetails[]>(this.baseUrl);
  }

  favoriteMovie(fave:MovieDetails) : Observable<MovieDetails>{
    return this.http.post<MovieDetails>(this.baseUrl, fave);
  }


}
