using Mediator;

Console.WriteLine("Mediator is a behavioral design pattern that reduces coupling between components of a program by making them communicate indirectly, through a special mediator object.");
Console.WriteLine();

// The client code.
Component1 component1 = new();
Component2 component2 = new();

new ConcreteMediator(component1, component2);

Console.WriteLine("Client triggets operation A.");
component1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D.");
component2.DoD();