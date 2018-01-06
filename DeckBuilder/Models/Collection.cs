using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder.Models
{
    public class Collection
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public IList<CardCollection> CardCollections { get; set; }
    }
}
