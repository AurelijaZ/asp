using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCdemo3.Models
{
    public class Album
    {
        public string title { get; set; }
        public string artist { get; set; }
        public string format { get; set; }
        public decimal price { get; set; }

        public Album (string title, string artist, string format, decimal price)
        {
            this.title = title;
            this.artist = artist;
            this.format = format;
            this.price = price;

            
        }
    }
}