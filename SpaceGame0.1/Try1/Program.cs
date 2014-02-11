using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Try1
{
    //Demonstrating window switch
    class Program
    {


        static void AskWhatNext()
        {
            Console.WriteLine("\nSwitch back to the window? (Y/N)");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                    {
                        string basePath = SampleInterface.Misc.stepOut(3);
                        string fullPath = System.IO.Path.Combine(basePath, @"SampleInterface\bin\Debug\SampleInterface.exe");
                        Process.Start(fullPath);
                        Process.GetCurrentProcess().CloseMainWindow();

                        break;
                    }
                case ConsoleKey.N:
                    Process.GetCurrentProcess().CloseMainWindow();
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wow!");
            AskWhatNext();
            
            
        }
    }
}
