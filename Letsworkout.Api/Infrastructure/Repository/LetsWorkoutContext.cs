using System;
using Letsworkout.Api.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace Letsworkout.Api.Infrastructure.Repository
{

    public class LetsWorkoutContext : DbContext
    {
        public LetsWorkoutContext(DbContextOptions<LetsWorkoutContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
    }
}