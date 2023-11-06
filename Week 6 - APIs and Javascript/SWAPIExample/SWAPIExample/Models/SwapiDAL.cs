using RestSharp;

namespace SWAPIExample.Models
{
    public class SwapiDAL
    {
        public static string baseUrl { get; set; } = @"https://swapi.dev/api/";
        public static SWPerson GetPerson(int id)
        {
            //Figure out your base url and your endpoint url 
            string endpoint = baseUrl + @"/people/" + id;

            RestClient client = new RestClient(endpoint);
            RestRequest request = new RestRequest();

            //This handles converting the JSON string for you
            SWPerson p = client.Get<SWPerson>(request);

            return p;
        }

        public static List<SWPerson> GetPeople()
        {
            string endpoint = baseUrl + @"/people";
            
            RestClient client = new RestClient(endpoint);
            RestRequest request = new RestRequest();
            PeopleListing topLevel = client.Get<PeopleListing>(request);
            List<SWPerson> people = topLevel.results.ToList();

            return people;
        }

        public static PeopleListing GetPage(int page)
        {
            string endpoint = baseUrl + @"/people?page="+page;
            RestClient client = new RestClient(endpoint);
            RestRequest request = new RestRequest();
            PeopleListing topLevel = client.Get<PeopleListing>(request);
            topLevel.page = page;
            return topLevel;

        }

        public static List<SWPerson> GetAllPeople()
        {
            string endpoint = baseUrl + @"/people";
            RestClient client = new RestClient(endpoint);
            RestRequest request = new RestRequest();
            PeopleListing topLevel = client.Get<PeopleListing>(request);

            int page = 2;
            List<SWPerson> allPeople = new List<SWPerson>();
            while(allPeople.Count <= 82)
            {
                endpoint = baseUrl + @"/people?page="+page;
                RestClient client2 = new RestClient(endpoint);
                RestRequest request2 = new RestRequest();
                PeopleListing topLevel2 = client.Get<PeopleListing>(request);
                allPeople.AddRange(topLevel2.results);
                page++;
            }

            return allPeople;
        }
    }
}
