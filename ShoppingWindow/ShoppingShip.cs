using SpaceGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ShoppingWindow
{
    /// <summary>
    /// Here the PlayerShip object is taken apart to be manipulate in the UI
    /// </summary>
    public class ShoppingShip
    {
        internal static PlayerShip theOne = PlayerShip.LoadShip();

        static Type ourShip = Type.GetType("theOne");

        internal static List<PropertyInfo> PrepareProps()
        {
            PropertyInfo[] originalProps = theOne.GetType().GetProperties();
            List<PropertyInfo> propsList = originalProps.ToList();
            List<PropertyInfo> integerProps = propsList.FindAll(x => x.PropertyType == typeof(int));

            return integerProps;            
        }
        
        

    }
}
