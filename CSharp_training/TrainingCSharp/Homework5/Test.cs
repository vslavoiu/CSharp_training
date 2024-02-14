class Test
{
    public static void Main(string[] args)
    {
        FirstBrowser browser = new FirstBrowser();
        browser.SendTextToElement();
        Console.WriteLine("Captured path: " + BrowserHelper.PathImage);
    }
}

