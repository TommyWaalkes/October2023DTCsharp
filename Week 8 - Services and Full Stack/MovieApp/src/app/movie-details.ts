// export interface MovieDetailsDB {
//     id:         number;
//     title:      string;
//     year:       string;
//     rated:      string;
//     released:   string;
//     runtime:    string;
//     genre:      string;
//     director:   string;
//     writer:     string;
//     actors:     string;
//     plot:       string;
//     language:   string;
//     country:    string;
//     awards:     string;
//     poster:     string;
//     ratings:    Rating[];
//     metascore:  string;
//     imdbRating: string;
//     imdbVotes:  string;
//     imdbID:     string;
//     type:       string;
//     dvd:        string;
//     boxOffice:  string;
//     production: string;
//     website:    string;
//     response:   string;
// }

export interface MovieDetails {
    Id:         number;
    Title:      string;
    Year:       string;
    Rated:      string;
    Released:   string;
    Runtime:    string;
    Genre:      string;
    Director:   string;
    Writer:     string;
    Actors:     string;
    Plot:       string;
    Language:   string;
    Country:    string;
    Awards:     string;
    Poster:     string;
    Ratings:    Rating[];
    Metascore:  string;
    imdbRating: string;
    imdbVotes:  string;
    imdbID:     string;
    Type:       string;
    DVD:        string;
    BoxOffice:  string;
    Production: string;
    Website:    string;
    Response:   string;
}


export interface Rating {
    Source: string;
    Value:  string;
}
