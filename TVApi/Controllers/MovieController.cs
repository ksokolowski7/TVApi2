using BusinessLogic.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TVProvider.Models;

namespace TVApi.Controllers
{
    public class MovieController : ApiController
    {
        private IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        [Route("movies/popular")]
        public async Task<IEnumerable<Movie>> GetPopularMovies()
        {
            var data = _movieService.GetPopularMovies();
            return await data;
        }

        [HttpGet]
        [Route("movies/comments")]
        public async Task<IEnumerable<CommentModel>> GetComments(string title)
        {
            var data = _movieService.GetMovieComments(title);
            return await data;
        }

        // COMMENT !!!
        // This way isn't in use because exist problem with string with special character sending in route parameter 

        //[HttpGet]
        //[Route("movies/{title}/comments")]
        //public async Task<IEnumerable<CommentModel>> GetComments(string title)
        //{
        //    var data = _movieService.GetMovieComments(title);
        //    return await data;
        //}
    }
}
