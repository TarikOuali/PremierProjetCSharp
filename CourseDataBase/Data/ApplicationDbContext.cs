using CourseDataBase.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDataBase.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Article> Articles { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public ApplicationDbContext() : base()
        {

        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CoursEFBaptiste;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
