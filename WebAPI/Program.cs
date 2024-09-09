var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IMovieService, MovieService>();

var app = builder.Build();



app.Run();
