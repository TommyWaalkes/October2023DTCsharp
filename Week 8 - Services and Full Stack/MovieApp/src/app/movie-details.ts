export interface MovieDetailsDB {
    id:         number;
    title:      string;
    year:       string;
    rated:      string;
    released:   string;
    runtime:    string;
    genre:      string;
    director:   string;
    writer:     string;
    actors:     string;
    plot:       string;
    language:   string;
    country:    string;
    awards:     string;
    poster:     string;
    ratings:    Rating[];
    metascore:  string;
    imdbRating: string;
    imdbVotes:  string;
    imdbID:     string;
    type:       string;
    dvd:        string;
    boxOffice:  string;
    production: string;
    website:    string;
    response:   string;
}

export interface MovieDetailsAPI {
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

class DetailsConverter{
    APItoDB(api:MovieDetailsAPI){
        let db: MovieDetailsDB = {
            id:api.Id,
            title:api.Title,
            year:api.Year,
            rated:api.Rated,
            released:api.Released,
            runtime:api.Runtime,
            genre:api.Genre,
            director:api.Director,
            writer:api.Writer,
            actors:api.Actors,
            plot:api.Plot,
            language:api.Language,
            country:api.Country,
            awards:api.Awards,
            poster:api.Poster,
            ratings:api.Ratings,
            metascore:api.Metascore,
            imdbRating:api.imdbRating,
            imdbVotes:api.imdbVotes,
            imdbID:api.imdbID,
            type:api.Type,
            dvd:api.DVD,
            boxOffice:api.BoxOffice,
            production: api.Production,
            website:api.Website,
            response:api.Response
        }
    }
}

export interface Rating {
    Source: string;
    Value:  string;
}
