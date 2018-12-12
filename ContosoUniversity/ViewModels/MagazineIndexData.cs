using System.Collections.Generic;
using ContosoUniversity.Models;

namespace ContosoUniversity.ViewModels
{
    public class MagazineIndexData
    {
        public IEnumerable<Magazine> Magazines { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public string Text { get; set; }
    }
}