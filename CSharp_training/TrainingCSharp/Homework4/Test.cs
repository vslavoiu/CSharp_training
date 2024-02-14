using FB;
using FF;

namespace Homework4.TrainingCSharp
{
    public class Test
    {
        static void Main(string[] args)
        {
            //Browser
            // Browser browser = new Browser();
            // browser.StartBrowser();
 
            //Firefox
            Firefox firefox = new Firefox();
            firefox.About();
            firefox.Ping();
            firefox.WindowWIdth = 1300;

            //Skype
            IComponent skype = new FC.Skype();
            skype.About();
            
            INetwork skype2 = new FC.Skype();
            skype2.Ping();
        }
    }
}