using Command;

Console.WriteLine("Command is behavioral design pattern that converts requests or simple operations into objects.");
Console.WriteLine();

// The client code can parameterize an invoker with any commands.
Invoker invoker = new();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));
Receiver receiver = new();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
invoker.DoSomethingImportant();