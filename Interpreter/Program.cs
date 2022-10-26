using Interpreter;

Console.WriteLine("Given a language, the Interpreter design pattern defines a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.");
Console.WriteLine();

Context context = new();
// Usually a tree 
List<AbstractExpression> list = new List<AbstractExpression>();
// Populate 'abstract syntax tree' 
list.Add(new TerminalExpression());
list.Add(new NonterminalExpression());
list.Add(new TerminalExpression());
list.Add(new TerminalExpression());
// Interpret
foreach (AbstractExpression exp in list)
{
    exp.Interpret(context);
}
// Wait for user
Console.ReadKey();