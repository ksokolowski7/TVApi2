using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<FriendEntity> Friends { get; set; }
        public ICollection<FavouriteMovieEntity> FavouriteMovies { get; set; }
    }
}
