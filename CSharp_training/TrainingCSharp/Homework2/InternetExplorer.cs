namespace D
{
    public class InternetExplorer
    {
        //Variables
        public int WindowWidth_int;
        public string? WindowWidth_string;
        public double WindowWidth_double;

        //this is the method to display 3 times the window width if the value is >1920, if not it will display 2x
        public void windowWidthValue(int WindowWidth_int)
        {
            if (WindowWidth_int > 1920)
            {
                int count = 0;
                while (count < 3)
                {
                Console.WriteLine($"--Window Width is bigger than 1920. Value is: {WindowWidth_int}--");
                    count++;
                }
            }
            else
            {
                for (int i = 0; i <2; i++)
                {
                Console.WriteLine($"--Warning! Window width is less than 1920! Value is: {WindowWidth_int}--");
                }
            }
        }
    }
    
}