using System.ComponentModel;
namespace FC
{
    public class Skype : IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine("Skype about");
        }
        public void Ping()
        {
            Console.WriteLine("Skype ping");
        }
    }
}