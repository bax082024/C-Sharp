public class MovieService : IMovieService
{
    private readonly List<Movie> _movies;

    public MovieService()
    {
        _movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Inception", Director = "Christopher Nolan", Year = 2010 },
            new Movie { Id = 2, Title = "The Matrix", Director = "The Wachowskis", Year = 1999 }
        };
    }

    public void AddMovie(Movie movie)
    {
        _movies.Add(movie);
    }

    public void DeleteMovie(int id)
    {
        var movie = _movies.FirstOrDefault(m => m.Id == id);
        if (movie != null)
        {
            _movies.Remove(movie);
        }
    }

    public Movie GetMovie(int id)
    {
        return _movies.FirstOrDefault(m => m.Id == id);
    }

    public IEnumerable<Movie> GetAllMovies()
    {
        return _movies;
    }

    public void UpdateMovie(int id, Movie updatedMovie)
    {
        var movie = _movies.FirstOrDefault(m => m.Id == id);
        if (movie != null)
        {
            movie.Title = updatedMovie.Title;
            movie.Director = updatedMovie.Director;
            movie.Year = updatedMovie.Year;
        }
    }
}
