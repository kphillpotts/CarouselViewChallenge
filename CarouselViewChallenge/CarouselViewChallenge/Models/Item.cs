using System;
using System.Collections.Generic;
using System.Text;

namespace CarouselViewChallenge.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool InStock { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

    }
}
