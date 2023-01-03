using System;
using FilmFinderXUI.Models;

namespace FilmFinderXUI.DataServices
{
	public interface IRestDataService
	{
		Task<List<MovieCatalogModel>> GetMoviesAsync();
        Task<UserModel> GetUserAsync();
        Task<List<MovieCatalogModel>> SearchMoviesAsync();
    }
}