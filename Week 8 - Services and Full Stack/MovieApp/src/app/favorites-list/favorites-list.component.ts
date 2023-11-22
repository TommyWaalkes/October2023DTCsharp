import { Component, OnInit } from '@angular/core';
import { OurMovieAPIService } from '../our-movie-api.service';
import { MovieDetails } from '../movie-details';

@Component({
  selector: 'app-favorites-list',
  templateUrl: './favorites-list.component.html',
  styleUrls: ['./favorites-list.component.css']
})
export class FavoritesListComponent implements OnInit {
  favorites:MovieDetails[] = [];
  constructor(private movieCrud:OurMovieAPIService){

  }
  ngOnInit(): void {
    this.movieCrud.getAllMovieDetails().subscribe(
      (result)=>{
        this.favorites = result;
      }
    )
  }
}
