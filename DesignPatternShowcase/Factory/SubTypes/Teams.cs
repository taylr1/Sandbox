using DesignPatternShowcase.Factory.Interface;

namespace DesignPatternShowcase.Factory.SubTypes;

public class Idaho : ITeam
{
    public int TeamId => (int)TeamFactory.Teams.IdahoPotatoes;
    public string TeamName => "Potatoes";
    public string TeamColor => "Red";
    public string TeamState => "ID";
}

public class Oregon : ITeam
{
    public int TeamId => (int)TeamFactory.Teams.OregonOddities;
    public string TeamName => "Oddities";
    public string TeamColor => "Blue";
    public string TeamState => "OR";
}

public class Michigan : ITeam
{
    public int TeamId => (int)TeamFactory.Teams.MichiganMegas;
    public string TeamName => "Megas";
    public string TeamColor => "Orange";
    public string TeamState => "MI";
}

public class Texas : ITeam
{
    public int TeamId => (int)TeamFactory.Teams.TexasTrackers;
    public string TeamName => "Trackers";
    public string TeamColor => "Yellow";
    public string TeamState => "TX";
}

public class NewYork : ITeam
{
    public int TeamId => (int)TeamFactory.Teams.NewYorkNelsons;
    public string TeamName => "Nelsons";
    public string TeamColor => "White";
    public string TeamState => "NY";
}