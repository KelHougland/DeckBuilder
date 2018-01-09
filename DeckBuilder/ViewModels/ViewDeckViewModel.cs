using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeckBuilder.Models;

namespace DeckBuilder.ViewModels
{
    public class ViewDeckViewModel
    {
        public Deck Deck { get; set; }
        public IList<CardDeck> Cards { get; set; }

    }
}
