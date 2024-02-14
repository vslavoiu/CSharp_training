using FB;
using System.ComponentModel;

namespace FF
{
    public class Firefox : Browser, IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine("Firefox about");
        }
        public void Ping()
        {
            Console.WriteLine("Firefox ping");
        }

        public override void StartBrowser()
        {
            throw new NotImplementedException();
        }
    }
}   