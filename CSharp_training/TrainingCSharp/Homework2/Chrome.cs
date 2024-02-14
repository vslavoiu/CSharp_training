using System;

namespace C
{
    public class Chrome
    {
        //Variables
        public int WindowWidth_int;
        public string? WindowWidth_string;
        public double WindowWidth_double;

        //this is the method to display the window width and the message
        public void windowWidthInfo(int windowWidth)
        {
            if (windowWidth > 1920)
            {
                Console.WriteLine($"--Window Width is: {windowWidth}--");
            }
            else
            {
                Console.WriteLine("--Warning! Window width is less than 1920!--");
            }
        }
    }
    
}