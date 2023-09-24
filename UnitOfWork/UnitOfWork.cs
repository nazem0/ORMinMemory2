using Microsoft.EntityFrameworkCore;
using ORMinMemory.Interfaces;
using ORMinMemory.Managers;
using ORMinMemory.Models;
namespace ORMinMemory.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStorage Storage;
        public UnitOfWork(IStorage _storage) {
            Storage = _storage;
        }
        private ICategoryManager _categoryMgr;
        public IPostManager _postMgr; 

        public ICategoryManager CategoryMgr
        {
            get {
                if(_categoryMgr == null)
                {
                    _categoryMgr = new CategoryManager(Storage.Categories);
                }
                return _categoryMgr;
            }
        }

        public IPostManager PostMgr {
            get
            {
                if (_postMgr == null)
                {
                    _postMgr = new PostManager(Storage.Posts);
                }
                return _postMgr;
            }
        }

        public int SaveChanges()
        {
            return Storage.SaveChanges();
        }
    }
}
