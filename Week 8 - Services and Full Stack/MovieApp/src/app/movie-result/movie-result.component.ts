import { Component, Input } from '@angular/core';
import { Result } from '../search-results';

@Component({
  selector: 'app-movie-result',
  templateUrl: './movie-result.component.html',
  styleUrls: ['./movie-result.component.css']
})
export class MovieResultComponent {
  @Input()
  result:Result = {} as Result;
}
