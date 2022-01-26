using System;
using System.ComponentModel.DataAnnotations;

namespace FilmCollector.Models
{
    public class CollectionResponse
    {
        [Key]
        [Required]
        public int FilmId { get; set; }

        [Required()]
        public string Title{ get; set;}
        [Required]
        public string Category { get; set; }
        [Required()]
        public int Year { get; set; }
        [Required()]
        public string Director { get; set; }
        [Required()]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public object Notes { get; set; }
    }
}

