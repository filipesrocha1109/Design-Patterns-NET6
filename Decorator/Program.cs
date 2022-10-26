using Decorator;

Console.WriteLine("Decorator is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside special wrapper objects, called decorators.");
Console.WriteLine();

Client client = new();

ConcreteComponent simple = new();
Console.WriteLine("Client: I get a simple component:");
client.ClientCode(simple);
Console.WriteLine();

ConcreteDecoratorA decorator1 = new (simple);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator1);
Console.WriteLine();


ConcreteDecoratorB decorator2 = new (simple);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator2);
Console.WriteLine();

ConcreteDecoratorB decorator3 = new(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator3);