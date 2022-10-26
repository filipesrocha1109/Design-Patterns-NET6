using Proxy;

Console.WriteLine("Proxy is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client. A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object.");
Console.WriteLine();

Client client = new ();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy.Proxy proxy = new (realSubject);
client.ClientCode(proxy);