using DependencyInjection.SocketAndPlug.Plug;
using DependencyInjection.SocketAndPlug.Socket;
using DependencyInjection.SocketAndPlug.Plug.Interface;
using DependencyInjection.SocketAndPlug.Socket.Interface;


// Dependency Injection

Console.WriteLine("Using plug Normally:");
IPlug plug = new HairDryerPlug();
ISocket socket = new Socket(plug);
socket.SendPower();

Console.WriteLine();

Console.WriteLine("Using plug Secured:");
IPlug securedPlug = new SecurePlug(plug, Identity.Parent); //decorated
socket = new Socket(securedPlug);
socket.SendPower();
