import { Component, EventEmitter, Output } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-post-form',
  templateUrl: './post-form.component.html',
  styleUrls: ['./post-form.component.css']
})
export class PostFormComponent {
  @Output() 
  newPostEvent = new EventEmitter<Post>();
  newPost:Post = {} as Post;
  show:boolean = false;

  makeNewPost(){
    this.newPostEvent.emit(this.newPost);
    this.newPost = {} as Post;
    this.toggleShow();
  }

  toggleShow(){
    this.show = !this.show;
  }
}
