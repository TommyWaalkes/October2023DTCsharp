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

  checkFavorite(title:string) :Observable<boolean>{
    return this.http.get<boolean>(this.baseUrl+"/isFavorite/"+title);
  }

  //Deleting is generally by SQL id. It will match and delete the row
  //You still need to subscribe to this though it is void
  //No data will be returned, the result var will not have anything in it
  deleteMovie(id:number ):Observable<void>{
    return this.http.delete<void>(this.baseUrl+"/"+id);
  }

  getMovie(id:number):Observable<MovieDetails>{
    return this.http.get<MovieDetails>(this.baseUrl + "/"+id);
  }

  updateMovie(id:number, newValues:MovieDetails):Observable<void>{
    return this.http.put<void>(this.baseUrl +"/"+id, newValues);
  }

}
