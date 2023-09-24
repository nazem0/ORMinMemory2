using ORMinMemory.Storage;
using ORMinMemory.UnitOfWork;
using ORMinMemory.Models;
using System;
public class Program
{
    public static void Main()
    {
        InMemoryStorage inMemoryStorage = new InMemoryStorage();
        UnitOfWork unitOfWork = new UnitOfWork(inMemoryStorage);
        unitOfWork.CategoryMgr.Add(new Category { Id = 1, Name = "Photographer", PictureURL = "https://www.example.com/assets/profilePicture.jpg" });
        unitOfWork.PostMgr.Add(new Post { Id = 1, Date = new DateOnly(2023, 9, 25), Title = "Post Title", Description = "Post Description", VendorID = 1182 });
        unitOfWork.SaveChanges();
        foreach (Category category in unitOfWork.CategoryMgr.Get())
        {
            Console.WriteLine(category.Name);
        }
        foreach (Post post in unitOfWork.PostMgr.Get())
        {
            Console.WriteLine(post.Title);
        }

    }
}