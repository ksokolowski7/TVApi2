using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVProvider.Models;

namespace BusinessLogic.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetPopularMovies();
        Task<IEnumerable<CommentModel>> GetMovieComments(string title);
    }
}
