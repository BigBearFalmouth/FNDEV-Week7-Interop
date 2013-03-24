using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageBeepDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsAPIWrapper.MessageBeep(WindowsAPIWrapper.MB_ICONHAND);

        }

            
    }
}
