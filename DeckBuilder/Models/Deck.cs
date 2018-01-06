using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckBuilder.Models
{
    public class Deck
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public IList<CardDeck> CardDecks { get; set; }
    }
}
