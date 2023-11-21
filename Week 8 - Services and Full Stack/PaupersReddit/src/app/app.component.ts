import { Component } from '@angular/core';
import { RedditService } from './reddit-service.service';
import { Welcome } from './reddit-posts';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PaupersReddit';
  welcome:Welcome = {} as Welcome;
  loading:boolean = true;
  sub:string = "";

  constructor(private redditService:RedditService){
    // this.redditService.getRedditPosts().subscribe(
    //   (result) =>{
    //     this.welcome = result; 
    //     this.loading = false; 
    //     console.log(result);
    //   }
    // )
  }

  SearchSub(){
    this.loading = true;
    this.redditService.searchBySubreddit(this.sub).subscribe(
      (result) =>{
        this.welcome = result;
        this.loading = false; 
      }
    )
  }
}
