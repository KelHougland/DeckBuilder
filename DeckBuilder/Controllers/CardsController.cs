using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeckBuilder.Data;
using DeckBuilder.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeckBuilder.Controllers
{


    public class CardsController : Controller
    {
        private ApplicationDbContext context;

        public CardsController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Card> cards = context.Cards.ToList();

            return View(cards);
        }
    }
}
