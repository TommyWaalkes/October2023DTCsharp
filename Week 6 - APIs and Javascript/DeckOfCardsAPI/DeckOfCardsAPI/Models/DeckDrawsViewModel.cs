namespace DeckOfCardsAPI.Models
{
    public class DeckDrawsViewModel
    {
        public Deck Deck { get; set; }
        public string DeckId { get; set; }
        public List<Card> Cards { get; set; }
    }
}
