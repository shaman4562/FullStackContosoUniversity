using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Article
    {
        public int ArticleID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        public string Text { get; set; }

        public int MagazineID { get; set; }

        public virtual Magazine Magazine { get; set; }

    }
}