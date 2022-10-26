Console.WriteLine("Singleton is a creational design pattern, which ensures that only one object of its kind exists and provides a single point of access to it for any other code.");

// The client code.
Singleton.Singleton s1 = Singleton.Singleton.GetInstance();
Singleton.Singleton s2 = Singleton.Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}