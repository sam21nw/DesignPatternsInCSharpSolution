public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();
    private static int numberOfInstances = 0;
    private Singleton()
    {
        System.Console.WriteLine("Instantiating inside the private constructor.");
        numberOfInstances++;
        System.Console.WriteLine($"Number of Instances = {numberOfInstances}");
    }

    public static Singleton Instance
    {
        get
        {
            System.Console.WriteLine("We already have an instance now. Use it.");
            return instance;
        }
    }

    // Quirks
    public static int MyInt = 25;
}