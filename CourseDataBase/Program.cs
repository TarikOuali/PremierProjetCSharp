// See https://aka.ms/new-console-template for more information
using CourseDataBase.Data;
using CourseDataBase.Data.Model;

Console.WriteLine("Hello, World!");


using (var ctx = new ApplicationDbContext())
{
    var blog = new Blog()
    {
        Name = "Blog dev",
        Description = "desc",
        Url = "http://exemple.com"
    };
    ctx.Blogs.Add(blog);

    var article = new Article()
    {
        Author = "khg",
        Content = "Article content",
        Date = DateTime.Now,
        Title = "title of my article",
        Url = "qoojehvode",
        Blog = blog
    };

    ctx.Articles.Add(article);

    await ctx.SaveChangesAsync();


}
