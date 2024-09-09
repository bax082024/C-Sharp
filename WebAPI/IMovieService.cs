

public interface IMovieService
{
    void AddMovie(Movie movie);
    void DeleteMovie(int id);
    Movie GetMovie(int id);
    IEnumerable<Movie> GetAllMovies();
    void UpdateMovie(int id, Movie updatedMovie);
}
