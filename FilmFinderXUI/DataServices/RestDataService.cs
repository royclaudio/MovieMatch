using System;
using System.Text.Json;
using FilmFinderXUI.Models;

namespace FilmFinderXUI.DataServices
{
	public class RestDataService : IRestDataService
	{
        private readonly HttpClient _httpClient;
        private string _baseAddress;
        private string _url;
        private JsonSerializerOptions _jsonSerializerOptions;

        public RestDataService()
		{
            _httpClient = new HttpClient();
            _baseAddress = "https://localhost:7250;http://localhost:5050";
            _url = $"{_baseAddress}/api";
            _jsonSerializerOptions = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
		}

        public async Task<List<MovieCatalogModel>> GetMoviesAsync()
        {
            List<MovieCatalogModel> movies = new List<MovieCatalogModel>();
            if( Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                return movies;
            }
            try {
                HttpResponseMessage response = await _httpClient.GetAsync($"{_url}/GetMovies");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    //yay
                    movies = JsonSerializer.Deserialize<List<MovieCatalogModel>>(content, _jsonSerializerOptions);
                }
            }
            catch
            {

            }
            return movies;

        }

        public Task<UserModel> GetUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<MovieCatalogModel>> SearchMoviesAsync()
        {
            throw new NotImplementedException();
        }
    }
}

