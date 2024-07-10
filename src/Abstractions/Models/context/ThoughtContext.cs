using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Abstractions.Models.context
{
    public class ThoughtContext : DbContext
    {
        public ThoughtContext(DbContextOptions<ThoughtContext> options) : base(options)
        {
            
        }


        public DbSet<Thought> Thoughts {get; set;}

        public DbSet<Comment> Comments {get; set;}
        
        public DbSet<User> Users {get; set;}
    }
}