import { Component, OnInit } from '@angular/core';
import { OurMovieAPIService } from '../our-movie-api.service';
import { MovieDetailsDB } from '../movie-details';

@Component({
  selector: 'app-favorites-list',
  templateUrl: './favorites-list.component.html',
  styleUrls: ['./favorites-list.component.css']
})
export class FavoritesListComponent implements OnInit {
  favorites:MovieDetailsDB[] = [];
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
