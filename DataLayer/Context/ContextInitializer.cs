using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class ContextInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var users = new List<UserEntity>
            {
            new UserEntity{FirstName="Carson",LastName="Alexander"},
            new UserEntity{FirstName="Meredith",LastName="Alonso"},
            new UserEntity{FirstName="Arturo",LastName="Anand"},
            new UserEntity{FirstName="Gytis",LastName="Barzdukas"},
            new UserEntity{FirstName="Yan",LastName="Li"},
            new UserEntity{FirstName="Peggy",LastName="Justice"},
            new UserEntity{FirstName="Laura",LastName="Norman"},
            new UserEntity{FirstName="Nino",LastName="Olivetto"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var friends = new List<FriendEntity>
            {
            new FriendEntity{FirstName="Carson",LastName="Alexander"},
            new FriendEntity{FirstName="Meredith",LastName="Alonso"},
            new FriendEntity{FirstName="Arturo",LastName="Anand"},
            new FriendEntity{FirstName="Gytis",LastName="Barzdukas"},
            new FriendEntity{FirstName="Yan",LastName="Li"},
            new FriendEntity{FirstName="Peggy",LastName="Justice"},
            new FriendEntity{FirstName="Laura",LastName="Norman"},
            new FriendEntity{FirstName="Nino",LastName="Olivetto"}
            };

            friends.ForEach(s => context.Friends.Add(s));
            context.SaveChanges();

            var favouriteMovies = new List<FavouriteMovieEntity>
            {
            new FavouriteMovieEntity{Name="Movie1"},
            new FavouriteMovieEntity{Name="Movie2"},
            new FavouriteMovieEntity{Name="Movie3"},
            new FavouriteMovieEntity{Name="Movie4"},
            new FavouriteMovieEntity{Name="Movie5"},
            };

            favouriteMovies.ForEach(s => context.FavouriteMovies.Add(s));
            context.SaveChanges();
        }
    }
}
