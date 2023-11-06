
public class PeopleListing
{
    public int count { get; set; }
    public string next { get; set; }
    public object previous { get; set; }
    public int page { get; set; } = 1;
    public SWPerson[] results { get; set; }
}


