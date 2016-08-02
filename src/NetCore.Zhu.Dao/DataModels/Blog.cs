using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Zhu.Dao.DataModels
{
    [Table("Post")]
    public class Blog
    {
        public Blog()
        {
            Post = new HashSet<Post>();
        }

        public int BlogId { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
