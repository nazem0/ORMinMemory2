using Microsoft.EntityFrameworkCore;
using ORMinMemory.Managers;
using ORMinMemory.Models;

namespace ORMinMemory.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryManager CategoryMgr { get; }
        IPostManager PostMgr { get; }
        int SaveChanges();
    }
}
