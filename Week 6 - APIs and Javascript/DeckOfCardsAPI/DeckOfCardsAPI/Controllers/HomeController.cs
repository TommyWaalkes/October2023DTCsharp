﻿using DeckOfCardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckOfCardsAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //This makes the initial and crafts a view model to have access to both the deck and cards 
        public IActionResult Index()
        {
            Deck deck = DeckOfCardsDAL.GetDeck();
            List<Card> cards = DeckOfCardsDAL.Draw(5, deck.deck_id);
            DeckDrawsViewModel dd = new DeckDrawsViewModel();
            dd.Cards = cards;
            dd.Deck = deck;
            return View(dd);
        }

        //This takes in a deck_id so we can draw again from the same deck
        public IActionResult DrawMore(string deckId)
        {
            List<Card> cards = DeckOfCardsDAL.Draw(5, deckId);
            DeckDrawsViewModel dd = new DeckDrawsViewModel();
            dd.DeckId = deckId;
            dd.Cards = cards; 
            return View(dd);

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