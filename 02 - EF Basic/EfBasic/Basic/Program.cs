using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SmartIT.DebugHelper;

namespace Basic
{
  class Program
  {
    static void Main(string[] args)
    {
      var connection = @"Server=(localdb)\mssqllocaldb;Database=BlogEfDB;Trusted_Connection=True;";

      //DbContextOptions<DataContext> options = new DbContextOptionsBuilder<DataContext>()
      //       .UseInMemoryDatabase(databaseName: "BasicDB")
      //       .Options;

      DbContextOptions<DataContext> options = new DbContextOptionsBuilder<DataContext>()
            .UseSqlServer(connection)
            .Options;
      //DataContext context = new DataContext(options);
      //context.Database.EnsureDeleted();
      //context.Database.EnsureCreated();

      using (var context = new DataContext(options))
      { // Creating,  using and consuming  DataContext.
        //context.Blog.Add(new Blog() { Id = 1, Title = "Cats" });
        //context.SaveChanges();
        //// work with context here

        ////Blog b = new Blog();
        //context.Blog.DDump("Blog List:");

        //Create Operation
        //var newBlogCats = new Blog() { Title = "Cats" };
        //context.Blog.Add(newBlogCats);
        //context.SaveChanges();
        //// or
        //var newBlogDogs = new Blog() { Title = "Dogs" };
        //context.Entry(newBlogDogs).State = EntityState.Added;
        //context.SaveChanges();
        //context.Blog.DDump("Blog List:");


        // Update Operation
        //var newBlogCats = new Blog() { Id = 1, Title = "Cats" };
        //context.Blog.Add(newBlogCats);
        //context.SaveChanges();
        ////
        //var findCats = context.Blog.Find(1); // id=1
        //findCats.Title = "Cats and Dogs";
        //context.Entry(findCats).State = EntityState.Modified;
        //context.SaveChanges();
        //context.Blog.DDump("Blog List:");


        // Delete Operation
        //var newBlogCats = new Blog() { Id = 1, Title = "Cats" };
        //context.Blog.Add(newBlogCats);
        //var newBlogDogs = new Blog() { Id = 2, Title = "Dogs" };
        //context.Entry(newBlogDogs).State = EntityState.Added;
        //context.SaveChanges();

        //context.Blog.DDump("Output: Before Delete context.Blog");
        //var findCats = context.Blog.Find(1); // id=1
        //context.Entry(findCats).State = EntityState.Deleted;
        //context.SaveChanges();
        //context.Blog.DDump("Output: After Delete context.Blog");


        // SQL Queries
        //var newBlogCats = new Blog() { Id = 1, Title = "Cats" };
        //context.Blog.Add(newBlogCats);
        //var newBlogDogs = new Blog() { Id = 2, Title = "Dogs" };
        //context.Entry(newBlogDogs).State = EntityState.Added;
        //context.SaveChanges();
        var blogs = context.Blog
          .FromSqlRaw("SELECT * FROM dbo.Blog")
          .ToList();
        blogs.DDump("SELECT * FROM dbo.Blog");

      }

    }
  }
}


