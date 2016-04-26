using Common.Settings;
using DataLayer.Context;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVProvider.Factory;
using TVProvider.Models;
using TVProvider.Provider;

namespace BusinessLogic.Services
{
    public class MovieService : IMovieService
    {
        private ICompositeProvider _provider;

        public MovieService(ICompositeProvider provider)
        {
            _provider = provider;
        }
        
        public Task<IEnumerable<Movie>> GetPopularMovies()
        {
            return _provider.GetPopularMovies();
        }

        public Task<IEnumerable<CommentModel>> GetMovieComments(string title)
        {
            return _provider.GetMovieComments(title);
        }
    }
}
