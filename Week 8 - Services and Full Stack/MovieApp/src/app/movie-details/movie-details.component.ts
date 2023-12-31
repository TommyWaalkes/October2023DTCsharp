import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MovieAPIService } from '../movie-api.service';
import { MovieDetails } from '../movie-details';
import { OurMovieAPIService } from '../our-movie-api.service';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {

  movieId: string | null  = "";
  movie: MovieDetails = {} as MovieDetails;
  favorites: MovieDetails[] = [];
  favorited: boolean = false;
  //You can inject as many services as you need on a component
  constructor(private routing: ActivatedRoute, 
    private movieApi : MovieAPIService,
    private crudAPI: OurMovieAPIService){
    
  }
  ngOnInit(): void {
    this.crudAPI.getAllMovieDetails().subscribe(
      (result) => {
        this.favorites = result; 
        console.log(this.favorites);
      }
    );
    this.movieId = this.routing.snapshot.paramMap.get("omdbId");
    console.log(this.movieId);
    if(this.movieId !== null){
      //try to grab from OMDB
      this.movieApi.getMovieDetailsById(this.movieId)
      .subscribe(
        (result) =>{
          this.movie = result; 
          console.log(this.movie);
          this.isFavorite();
        }
      )
    }
  }

  isFavorite(){
    this.crudAPI.checkFavorite(this.movie.Title).subscribe(
      (result) =>{
        console.log(result);
        this.favorited = result;
        //if a movie is favorited it should have an Id
        for(let i = 0; i < this.favorites.length; i++){
          let f:MovieDetails = this.favorites[i];
          if(f.imdbID === this.movie.imdbID){
            console.log(f.Id);
            this.movie.Id = f.Id;
          }
        }
      }
    );
  }

  favoriteMovie(){
    //Even if you don't react to something being favorited 
    //You still need the subscribe
    this.crudAPI.favoriteMovie(this.movie).subscribe(
      (result)=>{
        this.favorited = true;
      }
    );
  }

  deleteFavorite(){
    
    //For this work properly we still need subscribe. 
    this.crudAPI.deleteMovie(this.movie.Id).subscribe(
      ()=>{
        this.favorited = false; 
      }
    );
  }
}
