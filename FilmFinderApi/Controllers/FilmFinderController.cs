using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmFinderApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMauiAPI.Models;

namespace FilmFinderApi.Controllers
{
    [Route("api/[controller]/")]
    public class FilmFinderController : Controller
    {
        private readonly ILogger<FilmFinderController> _logger;
        private readonly ApplicationDbContext _context;

        public FilmFinderController(ILogger<FilmFinderController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: api/values

        [HttpGet("GetUsers/")]
        public async Task<List<UserModel>> GetUsers()
        {
            var context = await _context.Users.ToListAsync();

            return context;
            //var user = _context.Users;
            //return await user.ToListAsync();
        }
        [HttpGet("GetMovies/")]
        public async Task<List<MovieCatalogModel>> GetMovies()
        {

            var context = await _context.MovieCatalog.Take(10).ToListAsync();

            return context;
        }
        //GET /movies/name={id}` - finds all movies matching the specified name
        [HttpGet("Search/{name}")]
        public async Task<List<MovieCatalogModel>> SearchMovies(string name)
        {
            var context = await _context.MovieCatalog.Where(x=> x.Title.Contains(name)).ToListAsync();
            return context;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

