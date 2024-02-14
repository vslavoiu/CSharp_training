using C;
using D;

namespace E
{
    public class Browser
    {
        //Variables
        public int WindowWidth;
        public string WindowWidth_string = "1920";

    //Changes the value with the ones from Internet Explorer
        public virtual void ChangeWindowWidth2(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Window Width for Internet Explorer set from Browser is: " + newWindowWidth);
        }

    //Changes the value for Chrome with the ones from the browser
        public void ChangeWindowWidth1(string newWindowWidth_string)
        {
            WindowWidth_string = newWindowWidth_string;
            string intToString = Convert.ToString(newWindowWidth_string);
            Console.WriteLine($"This is the new Window Width value for Chrome set from Main: {intToString}");
        }

    //Reads the version value from Edge
        public virtual void About(int Version)
        {
            Console.WriteLine("Version from Edge: " + Version);
        }
    }
}