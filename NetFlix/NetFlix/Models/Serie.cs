using System;
using System.ComponentModel.DataAnnotations;

namespace NetFlix.Models
{
    public class Serie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        
        [Display(Name ="Realesed Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] //bring time that was edit with
        public DateTime RealeseData { get; set; }
        public string Genre { get; set; }
        public int Seasons { get; set; }
        public string Rating { get; set; }
    }
}