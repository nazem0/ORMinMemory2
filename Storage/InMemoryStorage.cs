using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ORMinMemory.Interfaces;
using ORMinMemory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMinMemory.Storage
{
    public class InMemoryStorage : DbContext, IStorage
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseInMemoryDatabase("DB");
            base.OnConfiguring(OptionsBuilder);
        }
    }
}
