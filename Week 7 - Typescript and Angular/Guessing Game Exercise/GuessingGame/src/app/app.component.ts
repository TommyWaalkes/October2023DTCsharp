import { Component } from '@angular/core';
import { Guess } from './guess';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'GuessingGame';
  selectedWord:string = "";
  possibleWords:string[] = [
    "hello", "world", "sandwich", "free", "bagel"
  ]; 

  guesses:Guess[] = [{guessWord:"ham", sharedLetters: 2, isMatch:true}]; 

  constructor(){
    this.selectedWord = this.getRandomWord();
    console.log(this.selectedWord);
  }

  //The min is inclusive, max is exclusive
  getRndInteger(min: number, max:number) {
    return Math.floor(Math.random() * (max - min) ) + min;
  }

  getRandomWord(){
    let num:number = this.getRndInteger(0, this.possibleWords.length);
    return this.possibleWords[num];
  }

  MakeNewGuess(word:string){
    let isMatch: boolean = word === this.selectedWord;
    let count: number = 0; 
    let loopTimes: number = 0; 
    if(isMatch){
      count = this.selectedWord.length;
    }
    else{
      if(word.length < this.selectedWord.length){
        loopTimes = word.length
      }
      else{
        loopTimes = this.selectedWord.length;
      }

      
      for(let i = 0; i < loopTimes; i++){
        let guessLet:string = word[i];
        let actualLet:string = this.selectedWord[i];
        if(actualLet === guessLet){
          count++; 
        }
      }
    }
    let result: Guess = {guessWord:word, sharedLetters:count, isMatch:isMatch}; 
    this.guesses.push(result);
  }
}
