using System;
using System.Collections.Generic;
using System.Text;
using InMemoryDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryDatabase.Data
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Entity> Entities { get; set; }
    }
}
