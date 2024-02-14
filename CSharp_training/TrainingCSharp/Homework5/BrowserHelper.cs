using System.Dynamic;
    public static class BrowserHelper
    {
        public static string PathImage { get; set; }

        public static void CaptureScreen()
        {
            Console.WriteLine("Screen captured");
            PathImage = "Path to captured screen";
        }
    }