using Microsoft.EntityFrameworkCore;
using ORMinMemory.Interfaces;
using ORMinMemory.Models;
using System.Collections.Generic;

namespace ORMinMemory.Managers
{
    public class Manager<T> : IManager<T> where T : BaseModel
    {
        public DbSet<T> Values { get; set; }
        public Manager(DbSet<T> values)
        {
            Values = values;
        }
        public void Add(T entity)
        {
            Values.Add(entity);
        }
        public IEnumerable<T> Get()
        { return Values; }
        public T Get(int _id)
        {
            foreach (T entity in Values)
            {
                if (entity.Id == _id)
                    return entity;
            }
            return null;
        }
        public void Remove(T entity)
        { Values.Remove(entity); }
        public void Delete(T entity)
        { Values.Remove(entity); }
        public void Update(T entity)
        { Values.Update(entity); }
    }
}
