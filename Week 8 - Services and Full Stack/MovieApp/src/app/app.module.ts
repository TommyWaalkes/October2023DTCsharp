import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { MovieResultComponent } from './movie-result/movie-result.component';
import { MovieDetailsComponent } from './movie-details/movie-details.component';
import { RouterModule, Routes } from '@angular/router';
import { MovieListComponent } from './movie-list/movie-list.component';

const routes:Routes = [
  {path:'Results', component:MovieListComponent}, 
  {path:'Details/:omdbId', component:MovieDetailsComponent},
  {path:'', pathMatch:"full", redirectTo:"Results"}
]

@NgModule({
  declarations: [
    AppComponent,
    MovieResultComponent,
    MovieDetailsComponent,
    MovieListComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    [RouterModule.forRoot(routes)]
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
