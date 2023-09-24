using Microsoft.EntityFrameworkCore;
using ORMinMemory.Interfaces;
using ORMinMemory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMinMemory.Managers
{
    public class PostManager:Manager<Post>,IPostManager
    {
        public PostManager(DbSet<Post> posts) : base(posts) { }
        //Any Additional Functionalities (Implementation) That Is Not Included In The Base Class (IManager);
    }
}
