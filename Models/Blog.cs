using System.Collections.Generic;

namespace Blogs.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}