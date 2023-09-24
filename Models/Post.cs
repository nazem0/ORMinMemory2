using System;

namespace ORMinMemory.Models
{
    public class Post:BaseModel
    {
        public int VendorID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly Date { get; set; }
    }
}
