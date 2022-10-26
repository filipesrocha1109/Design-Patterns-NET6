using State;

Console.WriteLine("State is a behavioral design pattern that allows an object to change the behavior when its internal state changes.");
Console.WriteLine();

// The client code.
var context = new Context(new ConcreteStateA());
context.Request1();
context.Request2();