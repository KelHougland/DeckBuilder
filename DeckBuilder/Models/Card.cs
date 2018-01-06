﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder.Models
{
    public class Card
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Element { get; set; }
        public int Cost { get; set; }
        public string Role { get; set; }
        public string Type { get; set; }
        public string Job { get; set; }
        public int Power { get; set; }
        public int ID { get; set; }

    }
}
