import { Component, Input } from '@angular/core';
import { Guess } from '../guess';

@Component({
  selector: 'app-guess-display',
  templateUrl: './guess-display.component.html',
  styleUrls: ['./guess-display.component.css']
})
export class GuessDisplayComponent {

  @Input() g:Guess = {} as Guess;
}
