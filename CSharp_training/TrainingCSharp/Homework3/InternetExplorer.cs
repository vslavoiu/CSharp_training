using System.Reflection.PortableExecutable;
using E;

namespace C
{
    public class InternetExplorer : Browser
    {
        //Method
        public override void ChangeWindowWidth2(int newWindowWidth)
        {
            Console.WriteLine("Internet Explorer browser method to change window width");
        }
    }

}