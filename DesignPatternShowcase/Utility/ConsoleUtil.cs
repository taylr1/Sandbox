namespace DesignPatternShowcase.Utility;

public static class ConsoleUtil
{
    private const char DIVIDER_CHAR = '=';
    private const int DIVIDER_CHAR_COUNT = 100;
    
    public static void CreateDivider(string sectionLabel) => Console.WriteLine(
        $"{sectionLabel}{new String(DIVIDER_CHAR, DIVIDER_CHAR_COUNT)}");
}