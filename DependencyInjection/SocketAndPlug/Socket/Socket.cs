using DependencyInjection.SocketAndPlug.Plug.Interface;
using DependencyInjection.SocketAndPlug.Socket.Interface;

namespace DependencyInjection.SocketAndPlug.Socket;

internal class Socket(IPlug plug) : ISocket
{
    public void SendPower()
    {
        plug.Connect();
    }
}
