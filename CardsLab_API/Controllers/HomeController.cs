using CardsLab_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace CardsLab_API.Controllers
{
    public class HomeController : Controller
    {

        CardDAL cd = new CardDAL();

        public IActionResult Index()
        {
            Deck deck = cd.ShuffleCards();
            return View(deck);
            //return View();
            //DeckAndCardsModel dacm = new DeckAndCardsModel();
            //dacm.Deck = cd.ShuffleCards();
            //dacm.Card = cd.DrawCard(string deckID, int num);
            //return View("Index", dacm);
        }

        public IActionResult DrawCards(string deckID, int numOfCards)
        {
            Deck d = cd.DrawCard(deckID, numOfCards);
            return View(d);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
