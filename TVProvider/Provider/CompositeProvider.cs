using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TVProvider.Factory;
using TVProvider.Helpers;
using TVProvider.Models;

namespace TVProvider.Provider
{
    public interface ICompositeProvider : ITVData
    {
    }

    public class CompositeProvider : ICompositeProvider
    {
        private IList<ITVData> _providers;

        public CompositeProvider(IList<ITVData> providers)
        {
            _providers = providers;
        }

        public async Task<IEnumerable<Movie>> GetPopularMovies()
        {
            var movies = new List<Movie>();

            foreach (var provider in _providers)
            {
                var popularMovies = await provider.GetPopularMovies();
                movies.AddRange(popularMovies);
            }
            return movies;
        }

        public async Task<IEnumerable<CommentModel>> GetMovieComments(string title)
        {
            var comments = new List<CommentModel>();
            foreach (var provider in _providers)
            {
                var commentsFromProvider = await provider.GetMovieComments(title);
                comments.AddRange(commentsFromProvider);
            }
            return comments;
        }
    }
}
