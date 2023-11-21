import { Component, Input } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-singe-post',
  templateUrl: './singe-post.component.html',
  styleUrls: ['./singe-post.component.css']
})
export class SingePostComponent {
  @Input() 
  post:Post = {} as Post;

  
}
