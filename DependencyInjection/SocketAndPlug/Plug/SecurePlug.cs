using DependencyInjection.SocketAndPlug.Plug.Interface;


namespace DependencyInjection.SocketAndPlug.Plug
{
    internal class SecurePlug(IPlug plug, Identity identity) : IPlug
    {

        public void Connect()
        {
            if(identity == Identity.Child)
            {
                Console.WriteLine("Plug is not Secured.");
                return;
            }

            if (identity == Identity.Parent)
            {
                Console.WriteLine("Plug is Secured.");
            }
            plug.Connect();
        }
    }
}
