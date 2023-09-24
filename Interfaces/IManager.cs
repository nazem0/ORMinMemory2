using Microsoft.EntityFrameworkCore;
using ORMinMemory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMinMemory.Interfaces
{
    public interface IManager <T> where T : BaseModel
    {
        DbSet<T> Values { get; set; }
        public void Add(T entity);
        public IEnumerable<T> Get();
        public T Get(int _id);
        public void Remove(T entity);
        public void Delete(T entity);
        public void Update(T entity);
    }
}
