﻿using Microsoft.EntityFrameworkCore;

namespace GameApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Game> Games { get; set; }
    }
}
