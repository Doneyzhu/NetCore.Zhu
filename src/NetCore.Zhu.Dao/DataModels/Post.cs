using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Zhu.Dao.DataModels
{

    [Table("Post")]
    public class Post
    {
        public Post()
        {

        }

        public int PostId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
