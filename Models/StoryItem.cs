using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReadMyLife.Models
{
    public class StoryItem
    {
        [Key]
        public int StoryID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorID { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public string Rating { get; set; }
        public int NumRatings { get; set; }
        public string Tag { get; set; }
        public string Date { get; set; }
        public string ImageURL { get; set; }
    }
}
