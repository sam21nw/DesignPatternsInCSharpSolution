System.Console.WriteLine("****** Singleton pattern demo ******\n");
System.Console.WriteLine("trying to create instance s1.");
Singleton s1 = Singleton.Instance;


System.Console.WriteLine("\ntrying to create instance s2.");
Singleton s2 = Singleton.Instance;
System.Console.WriteLine(s2);

if (s1 == s2)
{
    Console.WriteLine("Only one instance exists.");
}
else
{
    Console.WriteLine("Different instances exist.");
}