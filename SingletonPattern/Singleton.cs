public sealed class Singleton
{
    private static volatile Singleton instance = new Singleton();
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
            System.Console.WriteLine($"Number of Instances = {numberOfInstances}");
            return instance;
        }
    }

    // Quirks
    public static int MyInt = 25;
}