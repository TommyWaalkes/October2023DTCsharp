using RestSharp;

namespace DeckOfCardsAPI.Models
{
    public class DeckOfCardsDAL
    {
        public static Deck GetDeck()
        {
            string url = @"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
           
            Deck output = client.Get<Deck>(request);

            return output; 
        }

        public static List<Card> Draw(int amount, string deckId)
        {
            string url = $@"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={amount}";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();

            CardDraws draws = client.Get<CardDraws>(request);

            return draws.cards.ToList();
        }
    }
}
