namespace FB
{    
    public abstract class Browser
    {
        private int windowWidth;
        public int WindowWIdth
        {
            get { return windowWidth; }
            set
            {
                if (value < 1024)
                {
                    Console.WriteLine("Minimum width value is 1024");
                }
                else if (value > 1920)
                {
                    Console.WriteLine("Maximum width value is 1920");
                }
                else
                {
                    windowWidth = value;
                    Console.WriteLine("Browser width value set to: " + value);
                }
            }
        }
        public abstract void StartBrowser();
    }
}