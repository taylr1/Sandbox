using DesignPatternShowcase.Factory.Interface;
using DesignPatternShowcase.Factory.SubTypes;

namespace DesignPatternShowcase.Factory;

/// <summary>
/// the factory pattern is useful in scenarios where you are returning an object based on a particular input, and the classes
/// that can be returned based on the value from said input all inherit from a common interface. 
/// </summary>
public class TeamFactory
{
    public enum Teams
    {
        MichiganMegas = 1, 
        IdahoPotatoes = 2, 
        OregonOddities = 3, 
        NewYorkNelsons = 4, 
        TexasTrackers = 5
    }
    
    public ITeam GetTeam(Teams team)
    {
        try
        {
            switch (team)
            {
                case Teams.IdahoPotatoes:
                    return new Idaho();
                case Teams.MichiganMegas:
                    return new Michigan();
                case Teams.OregonOddities:
                    return new Oregon();
                case Teams.NewYorkNelsons:
                    return new NewYork();
                case Teams.TexasTrackers:
                    return new Texas();
            }

            throw new ArgumentOutOfRangeException(nameof(team), team, "Requested team not supported");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}