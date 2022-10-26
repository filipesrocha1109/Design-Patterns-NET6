using Bridge;

Console.WriteLine("Bridge is a structural design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.");
Console.WriteLine();

Client client = new();

Abstraction abstraction;
// The client code should be able to work with any pre-configured
// abstraction-implementation combination.
abstraction = new Abstraction(new ConcreteImplementationA());
client.ClientCode(abstraction);

Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
client.ClientCode(abstraction);