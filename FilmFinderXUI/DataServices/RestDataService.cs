using System;
using System.Diagnostics;
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
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator,
            };
            _httpClient = new HttpClient(handler);
            _url = "https://localhost:7250/api/FilmFinder";
            //_url = $"{_baseAddress}/api";
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task<List<MovieCatalogModel>> GetMoviesAsync()
        {
            List<MovieCatalogModel> movies = new List<MovieCatalogModel>();
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                return movies;
            }
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{_url}/GetMovies");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    //yay
                    movies = JsonSerializer.Deserialize<List<MovieCatalogModel>>(content, _jsonSerializerOptions);
                    var i = 0;
                    i++;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
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

