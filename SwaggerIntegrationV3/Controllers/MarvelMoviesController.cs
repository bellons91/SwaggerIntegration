using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace SwaggerIntegrationV3.Controllers
{
    // https://www.imdb.com/list/ls026696709/

    [Route("api/[controller]")]
    [ApiController]
    public class MarvelMoviesController : ControllerBase
    {

        /// <summary>
        /// Get all the Marvel movies
        /// </summary>
        /// <returns>List of Marvel movies</returns>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        /// <summary>
        /// Returns a movie given its ID
        /// </summary>
        /// <param name="id">ID of the movie to be found</param>
        /// <returns>The related movie if found. Null otherwise</returns>
        // GET api/<MarvelMoviesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Movie Get(int id)
        {
            return movies.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Adds a Marvel movie to the list
        /// </summary>
        /// <param name="value">Movie to be added</param>
        // POST api/<MarvelMoviesController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movies.Add(value);
        }


        /// <summary>
        /// Removes a movie from the list
        /// </summary>
        /// <param name="id">Id of the movie to be deleted</param>
        // DELETE api/<MarvelMoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAll(m => m.Id == id);
        }

        private static readonly List<Movie> movies = new List<Movie>() {
            new Movie{
                Id = 1,
                Title="Iron Man",
                PublicationYear = 2008,
                Rating=7.9f,
                Stars = new []{ "Robert Downey Jr.", "Gwyneth Paltrow", "Terrence Howard", "Jeff Bridges" }
            },
            new Movie{
                Id = 2,
                Title="Thor",
                PublicationYear = 2011,
                Rating=7f,
                Stars = new []{ "Chris Hemsworth", "Anthony Hopkins", "Natalie Portman", "Tom Hiddleston" }
            },
             new Movie{
                Id = 3,
                Title=" Guardians of the Galaxy",
                PublicationYear = 2014,
                Rating=8f,
                Stars = new []{ "Chris Pratt", "Vin Diesel", "Bradley Cooper", "Zoe Saldana" }
            }
        };

    }
}
