using E;

namespace A
{
    public class Firefox : Browser
    {
        //Method
        public virtual void SetProfile(string profileName)
        {
            Console.WriteLine("This is the Profile Name set from Main: " + profileName);
        }
    }
}