using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

public class FirstBrowser
{
    static void FindElement()
    {
        throw new Exception("Element not found");
    }

    public void SendTextToElement()
    {
        try
        {
            FindElement();
        }
        catch
        {
            BrowserHelper.CaptureScreen();
            Console.WriteLine("Call failed");
        }
        finally
        {
            BrowserHelper.PathImage = BrowserHelper.PathImage;
            Console.WriteLine("Screen Captured");
        }
    }

    //public var - The code is accessible for all classes
    public int PublicResolution;
    //internal var - The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
    internal int InternalResolution;
    //private var - The code is only accessible within the same class
    private int PrivateResolution;
    //protected var - The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
    protected int ProtectedResolution;
    //protected internal var
    protected internal int ProtectedInternalResolution;
    //default var
    int DefaultResolution;
}
    public class Firefox
    {
        public void TestAccess()
        {
            //Accessing variables from Browser class
            FirstBrowser browser = new FirstBrowser();
            // browser.PublicResolution;            //- this is accessable
            // browser.InternalResolution;          //- this is not accessable (From a different class)
            // browser.PrivateResolution;           //- this is not accessable
            // browser.ProtectedResolution;         //- this is not accessable
            // browser.ProtectedInternalResolution; //- this is not accessable
            // browser.DefaultResolution;           //- this is not accessable
        }
    }

    public class Chrome : FirstBrowser
    {
        public void TestAccess()
        {
            //Accessing variables from Browser class
            // PublicResolution;            //- this is not accessable
            // InternalResolution;          //- this is not accessable
            // PrivateResolution;           //- this is not accessable
            // ProtectedResolution;         //- this is accessable
            // ProtectedInternalResolution; //- this is accessable
            // DefaultResolution;           //- this is not accessable
        }
    }