[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public IEnumerable<Movie> GetMovies()
    {
        return _movieService.GetAllMovies();
    }

    [HttpGet("{id}")]
    public ActionResult<Movie> GetMovie(int id)
    {
        var movie = _movieService.GetMovie(id);
        if (movie == null)
        {
            return NotFound();
        }
        return movie;
    }

    [HttpPost]
    public ActionResult AddMovie(Movie movie)
    {
        _movieService.AddMovie(movie);
        return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteMovie(int id)
    {
        _movieService.DeleteMovie(id);
        return NoContent();
    }

    [HttpPut("{id}")]
    public ActionResult UpdateMovie(int id, Movie updatedMovie)
    {
        _movieService.UpdateMovie(id, updatedMovie);
        return NoContent();
    }
}
