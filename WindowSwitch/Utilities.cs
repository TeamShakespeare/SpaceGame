using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace WindowSwitch
{
    public class Utilities
    {
        public static void SwitchToConsole()
        {
            string consolePath = @"..\..\..\SpaceGame\bin\Debug\SpaceGame.exe";
            Process.Start(consolePath);
            Process.GetCurrentProcess().CloseMainWindow();
        }

        public static void SwitchToWindow()
        {           
            string windowPath =  @"..\..\..\ShoppingWindow\bin\Debug\ShoppingWindow.exe";
            Process.Start(windowPath);
            Process.GetCurrentProcess().CloseMainWindow();
        }

        /// <summary>
        /// This function should take the instance of PlayerShip and save its fields and properties to a file.
        /// </summary>
        /// <param name="obj"></param>
        public static void SaveToFile(Object obj)
        {
            var properties = obj.GetType().GetProperties();
            var fields = obj.GetType().GetFields();                    

            using (StreamWriter sw = new StreamWriter(@"..\..\..\CurrentState.txt"))
            {                

               //Read into properties here
            }
        }
        
        

    }
}
