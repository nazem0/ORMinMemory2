using Microsoft.EntityFrameworkCore;
using ORMinMemory.Models;

namespace ORMinMemory.Interfaces
{
    public interface IStorage
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Post> Posts { get; set; }
        int SaveChanges();
    }
}
