using C;

namespace D
{
    public class Edge : InternetExplorer
    {
        //Variable
        public int Version = 2;
        //Method
        public void newFeatureFunction(int newVersion)
        {
            Version = newVersion;
            Console.WriteLine("This is the new feature function from Edge. Version: " + newVersion);
        }

    }

}