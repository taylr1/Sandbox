namespace DesignPatternShowcase.Singleton;

/// <summary>
/// The singleton design pattern should be used in cases where a class needs to be globally accessible and is used in a fairly
/// consistent manner. Although it should not be overused as it can be fairly memory intensive since it will persist essentially from
/// the point of it's first usage until an application is restarted or closed. 
/// </summary>
public class Singleton
{
    private static Singleton? _instance;
    
    // singleton's are particularly prone to thread safety issues
    // as you may have multiple threads attempting to access the object simultaneously 
    private static readonly object _lock = new object();
    
    // constructor should be private, as singleton's should not be initialized by normal means 
    // the singleton instance exists in memory the same way any static reference would
    // all callers are pointed to the same singleton instance
    // similar to a static class but unlike a static class it can implement interfaces 
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            lock (_lock)
            {
                return _instance ??= new Singleton();
            }
        }
    }

    public void SayHello()
    {
        Console.WriteLine("Hello from singleton!");
    }
}