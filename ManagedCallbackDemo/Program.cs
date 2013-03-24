using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ManagedCallbackDemo
{
    public delegate Boolean EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

    class Program
    {
        static void Main(string[] args)
        {
            Enumerator en = new Enumerator();
            EnumWindowsProc ewc = new EnumWindowsProc(en.VisitWindow);
            WindowsAPIWrapper.EnumWindows(ewc, (IntPtr)0);
            Console.ReadKey();
        }

        class WindowsAPIWrapper
        {
            [DllImport("User32.dll", SetLastError = true)]
            public static extern Int32 EnumWindows(
                [MarshalAs(UnmanagedType.FunctionPtr)]
                EnumWindowsProc lpEnumFunc,
                IntPtr lParam);

            [DllImport("User32.dll", SetLastError = true)]
            public static extern Int32 GetWindowText(
                IntPtr hWnd,
                StringBuilder lpString,
                int nMaxCount);
        }

        class Enumerator
        {
            private const int SIZE = 100;

            public Boolean VisitWindow(IntPtr hWnd, IntPtr lParam)
            {
                Console.WriteLine("Window handle is {0}", hWnd.ToString());
                StringBuilder windowText = new StringBuilder(SIZE);
                if (WindowsAPIWrapper.GetWindowText(hWnd, windowText, SIZE) != 0)
                {
                    Console.WriteLine("Window title is {0}", windowText);
                }
                Console.WriteLine();
                return true;
            }
        }
    }
}
