import { Component } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-social-posts',
  templateUrl: './social-posts.component.html',
  styleUrls: ['./social-posts.component.css']
})
export class SocialPostsComponent {
  posts:Post[] = [
  {title:"I like pineapple on pizza", thought:"It's good on pizza, I am so brave."},
  {title:"Is a hamburger a sandwich?", thought:"Guys I'm very confused"}, 
  {title:"Birds are very real", thought:"I love Nasa and CIA"}, 
  {title:"I like Turtles", thought:"Turtles are cool"}
  ]

  AddPost(newPost:Post){
    this.posts.push(newPost);
  }
  
}
