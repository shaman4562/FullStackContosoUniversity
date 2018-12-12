using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Magazine
    {
        
        public int MagazineID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Genre { get; set; }

        public virtual ICollection<Article> Articles{ get; set; }
    }
}