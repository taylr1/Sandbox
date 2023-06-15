namespace DesignPatternShowcase.Factory.Interface;

public interface ITeam
{
    int TeamId { get; }
    string TeamName { get; }
    string TeamColor { get; }
    string TeamState { get; }
}