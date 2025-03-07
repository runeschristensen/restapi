using System.Text.Json;
using Microsoft.AspNetCore.Components.Web;
using Movies.Api.Sdk;
using Movies.Contracts.Requests;
using Refit;

var moviesApi = RestService.For<IMoviesApi>("https//localhost:5001");

var movie = await moviesApi.GetMovieAsync("test");

var request = new GetAllMoviesRequest 
{
    Title = null,
    Year = null,
    SortBy= null,
    Page = 1,
    PageSize = 3
};

var movies = await moviesApi.GetMoviesAsync(request);

Console.WriteLine(JsonSerializer.Serialize(movie));