
    public class Edge
    {
        public void TestAccess()
        {
        //Accessing variables from Browser class
        FirstBrowser browser = new FirstBrowser();    
        // browser.PublicResolution;            //- this is accessable
        // browser.InternalResolution;          //- this is not accessable
        // browser.PrivateResolution;           //- this is not accessable
        // browser.ProtectedResolution;         //- this is not accessable
        // browser.ProtectedInternalResolution; //- this is accessable
        // browser.DefaultResolution;           //- this is not accessable
        }
    }