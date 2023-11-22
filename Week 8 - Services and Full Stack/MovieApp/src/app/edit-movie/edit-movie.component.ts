import { Component, OnInit } from '@angular/core';
import { MovieDetails } from '../movie-details';
import { OurMovieAPIService } from '../our-movie-api.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-movie',
  templateUrl: './edit-movie.component.html',
  styleUrls: ['./edit-movie.component.css']
})
export class EditMovieComponent implements OnInit {
  id:number = 0;
  editMovie: MovieDetails = {} as MovieDetails;

  constructor(private movieCrud: OurMovieAPIService, 
    private routing:ActivatedRoute){

  }
  ngOnInit(): void {
    let raw =  this.routing.snapshot.paramMap.get("id");
    //console.log(raw)
    let s = raw as string; 
    //console.log(s);
    this.id = parseInt(s);

    this.movieCrud.getMovie(this.id).subscribe(
      (result) =>{
        console.log(result)
        this.editMovie = result;
      }
    )
  }

  updateMovie(){
    //For updates you need 2 things: 
    //1) the primary for the row to update 
    //2) the new values aka the modified object
    this.movieCrud.updateMovie(this.id, this.editMovie).subscribe();
  }


}
