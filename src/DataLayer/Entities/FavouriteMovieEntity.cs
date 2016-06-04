﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class FavouriteMovieEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FriendEntity> Friends { get; set; }
        public ICollection<UserEntity> Users { get; set; }
    }
}
