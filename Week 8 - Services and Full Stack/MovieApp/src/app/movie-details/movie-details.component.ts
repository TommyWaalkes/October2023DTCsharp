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
  //You can inject as many services as you need on a component
  constructor(private routing: ActivatedRoute, 
    private movieApi : MovieAPIService,
    private crudAPI: OurMovieAPIService){
    
  }
  ngOnInit(): void {
    this.movieId = this.routing.snapshot.paramMap.get("omdbId");
    console.log(this.movieId);
    if(this.movieId !== null){
      //try to grab from OMDB
      this.movieApi.getMovieDetailsById(this.movieId)
      .subscribe(
        (result) =>{
          this.movie = result; 
        }
      )
    }
  }

  favoriteMovie(){
    //Even if you don't react to something being favorited 
    //You still need the subscribe
    this.crudAPI.favoriteMovie(this.movie).subscribe();
  }
}
