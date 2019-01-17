using System;

namespace NetFlix.Models
{
    public class Serie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime RealeseData { get; set; }
        public string Genre { get; set; }
        public int Seasons { get; set; }
        public string Rating { get; set; }
    }
}