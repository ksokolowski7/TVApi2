using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public interface IContext : IDisposable
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<FriendEntity> Friends { get; set; }
        DbSet<FavouriteMovieEntity> FavouriteMovies { get; set; }
        DbSet<TestEntity> Tests { get; set; }
        DbSet<Test2Entity> Tests2 { get; set; }
        DbSet<MovieEntity> Movies { get; set; }

        int SaveChanges();
    }
}
