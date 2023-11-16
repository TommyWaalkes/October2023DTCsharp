import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-make-new-guess',
  templateUrl: './make-new-guess.component.html',
  styleUrls: ['./make-new-guess.component.css']
})
export class MakeNewGuessComponent {

  @Output() newGuessEvent = new EventEmitter<string>();
  word:string = "";

  EmitWord(){
    this.newGuessEvent.emit(this.word);
  }
}
