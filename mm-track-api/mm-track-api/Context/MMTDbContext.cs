using Microsoft.EntityFrameworkCore;
using mm_track_api.Models.Entity;
using System;

namespace mm_track_api.Context
{
    public class MMTDbContext : DbContext
    {
        public MMTDbContext(DbContextOptions<MMTDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
