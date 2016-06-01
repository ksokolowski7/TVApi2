using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TVProvider.Models;

namespace TVProvider.Provider
{ 
    public interface ITVData
    {
        Task<IEnumerable<CommentModel>> GetMovieComments(string title);
        Task<IEnumerable<Movie>> GetPopularMovies();
    }
}
