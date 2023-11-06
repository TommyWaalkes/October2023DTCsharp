﻿
public class SWPerson
{
    public string name { get; set; }
    public string height { get; set; }
    public string mass { get; set; }
    public string hair_color { get; set; }
    public string skin_color { get; set; }
    public string eye_color { get; set; }
    public string birth_year { get; set; }
    public string gender { get; set; }
    public string homeworld { get; set; }
    public string[] films { get; set; }
    public string[] species { get; set; }
    //If you pull in starships and/or vehicles, you'd need to put those classes here
    public object[] vehicles { get; set; }
    public object[] starships { get; set; }
    public DateTime created { get; set; }
    public DateTime edited { get; set; }
    public string url { get; set; }
}
