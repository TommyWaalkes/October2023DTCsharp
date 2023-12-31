import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Welcome } from './reddit-posts';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RedditService {
  baseUrl:string ="https://www.reddit.com/r/aww/.json";
  constructor(private http:HttpClient) { }

  getRedditPosts():Observable<Welcome>{
    return this.http.get<Welcome>(this.baseUrl);
  }

  searchBySubreddit(sub:string){
    let url:string = `https://www.reddit.com/r/${sub}/.json`;
    return this.http.get<Welcome>(url);
  }
}
