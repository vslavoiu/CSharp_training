using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Homework1.TrainingCSharp

{
    public class Browser
    {
        // These are the properties for Width and Height
        public int WindowWidth;
        public int WindowHeight;

        //This is a constructor used to set the initial values for Width and Height
        public Browser(int initialWindowWidth, int InitialWindowHeight)
        {
            WindowWidth = initialWindowWidth;
            WindowHeight = InitialWindowHeight;
        }

        //This method is used to change the Width
        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
        }

        //This method is used to change the Height
        public void ChangeWindowHeight(int newWindowHeight)
        {
            WindowHeight = newWindowHeight;
        }

        //This is the method to display browser's width and height in the console
        public void DisplayResolution()
        {
            Console.WriteLine($"New Browser Resolution: {WindowWidth}x{WindowHeight}");
        }

    }
}