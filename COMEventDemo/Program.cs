using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SHDocVw;

namespace COMEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of Internet Explorer
            InternetExplorer ie = new InternetExplorerClass();
            // set up event handlers
            ie.OnVisible +=
                new DWebBrowserEvents2_OnVisibleEventHandler(ieVisible);
            ie.TitleChange +=
                new DWebBrowserEvents2_TitleChangeEventHandler(ieTitleChange);

            // display Internet Explorer
            // and navigate to user's selected home page
            ie.Visible = true;
            object noValue = System.Reflection.Missing.Value;   // don't want to supply values for some parameters of Navigate method
            ie.Navigate(@"http://www.microsoft.com", ref noValue, ref noValue, ref noValue, ref noValue);
            Console.ReadLine();
        }

        private static void ieTitleChange(string title)
        {
            Console.WriteLine("Title changed to: {0}", title);
        }

        private static void ieVisible(bool isVisible)
        {
            Console.WriteLine("Internet Explore visible: {0}", isVisible);
        }
    }
}
