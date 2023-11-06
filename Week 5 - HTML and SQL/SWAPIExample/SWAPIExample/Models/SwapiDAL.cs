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
    }
}
