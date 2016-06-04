using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class Context : DbContext, IContext
    {
        public Context() : base("DefaultConnection")
        {
        }
        public Context(IDbInterceptor interceptor) : base("DefaultConnection")
        {
            DbInterception.Add(interceptor);
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<FriendEntity> Friends { get; set; }
        public DbSet<FavouriteMovieEntity> FavouriteMovies { get; set; }
        public DbSet<Test2Entity> Tests2 { get; set; }
        public DbSet<TestEntity> Tests { get; set; }
        public DbSet<MovieEntity> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
