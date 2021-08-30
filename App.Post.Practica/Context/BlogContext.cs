
using App.Post.Practica.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Post.Practica.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Posts> Posts { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Comments> Comments { get; set; } = null!;
        
        
    }
}
