// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] names = { "Vader", "Luke", "Obi Wan Kenobi", "Palpatine" };
int index = AddStarWarsCharacter(names);
Console.WriteLine(index);

Dictionary<string, int> namesToPowers = new Dictionary<string, int>();
namesToPowers.Add("Luke", 1000000);
namesToPowers.Add("Obi Wan", 9000);
namesToPowers.Add("Vader", 50000);
namesToPowers.Add("Yoda", 7777);
string nameHighest = DeathStarCombatLoop(namesToPowers);
Console.WriteLine(nameHighest);

string nameHighest2 = DeathStarCombatLinq(namesToPowers);
Console.WriteLine(nameHighest2);

string[] planets = { "Tatooine", "Dagobah", "Couresant", "Dantooine", "Hoth" };
List<string> planetsList = ConvertPlanetsLongway(planets);
foreach(string planet in planetsList)
{
    Console.WriteLine(planet);
}

double avg = AverageDroids(new List<int>() { 12, 30, 19, 35, 101, 22 });
Console.WriteLine(avg);

string output = TrytoCatchVader("100");
string output2 = TrytoCatchVader("sxzdfcgvh");
Console.WriteLine(output);
Console.WriteLine(output2);

static int AddStarWarsCharacter(string[] characters)
{
    if (characters.Contains("Yoda"))
    {
        for(int i  = 0; i < characters.Length; i++)
        {
            string c = characters[i];
            if (c == "Yoda")
            {
                return i; 
            }
        }

    }
        return -1;
}

static string DeathStarCombatLoop(Dictionary<string, int> nameToPower)
{
    int highest = 0;
    string name = "";
    foreach(KeyValuePair<string,int> kvp in  nameToPower)
    {
        if(kvp.Value > highest)
        {
            highest = kvp.Value;
            name = kvp.Key;
        }
    }

    return name;
}

static string DeathStarCombatLinq(Dictionary<string, int> nameToPower)
{
    int power = nameToPower.Values.Max();
    KeyValuePair<string, int> name = nameToPower.Where(kvp => kvp.Value  == power).First();
    return name.Key;
}

static List<string> ConvertPlanets(string[] planets)
{
    List<string> output = planets.Reverse().ToList();
    return output;
}

static List<string> ConvertPlanetsLongway(string[] planets)
{
    //Lets pretend there's no toList() or Reverse() 
    List<string> output = new List<string>();
    for(int i = planets.Length -1; i >= 0; i--)
    {
        string planet = planets[i];
        output.Add(planet);
    }

    return output; 
}

static double AverageDroids(List<int> droids)
{
    return droids.Where(d => d % 2 ==0).Average();
}

static string TrytoCatchVader(string input)
{
    int value = 0;
    bool worked = int.TryParse(input, out value);

    if(worked== true)
    {
        return "Vader was captured"; 
    }
    else
    {
        return "Vader got away";
    }
}