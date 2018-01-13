using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeckBuilder.Models;
using DeckBuilder.Data;
using DeckBuilder.ViewModels;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeckBuilder.Controllers
{
    public class DeckController : Controller
    {

        private ApplicationDbContext context;

        public DeckController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Deck> decks = context.Decks.ToList(); 

            return View(decks);
        }

        public IActionResult Add()
        {
            AddDeckViewModel addDeckViewModel = new AddDeckViewModel();
            return View(addDeckViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddDeckViewModel addDeckViewModel)
        {
            if (ModelState.IsValid)
            {
                Deck newDeck = new Deck
                {
                    Name = addDeckViewModel.Name
                };

                context.Decks.Add(newDeck);
                context.SaveChanges();
                return Redirect("/Deck/ViewDeck/" + newDeck.ID);
            }
            return View(addDeckViewModel);
        }

        public IActionResult ViewDeck(int id)
        {
            List<CardDeck> deckCards = context.CardDecks.Include(deckCard => deckCard.Card).Where(cd => cd.DeckID == id).ToList();
            Deck currentDeck = context.Decks.Single(c => c.ID == id);

            ViewDeckViewModel viewDeckViewModel = new ViewDeckViewModel();

            viewDeckViewModel.Cards = deckCards;
            viewDeckViewModel.Deck = currentDeck;

            return View(viewDeckViewModel);
        }

    }
}
