using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDataBase.Data.Model
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public DateTime Date { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        [StringLength(120)]
        public string Url { get; set; }
        public string Content { get; set; }

        public Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}
