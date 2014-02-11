using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface
{
    public class Misc
    {

        /// <summary>
        /// Finds a path, a number of levels above the current one, so that another directory in the same solution can be accessed
        /// </summary>
        /// <param name="directoriesCount">The number of directories to step out of.</param>
        /// <returns></returns>
        public static string stepOut(int directoriesCount)
        {
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;

            for (int i = 0; i < directoriesCount; i++)
            {
                int mark = currentPath.LastIndexOf('\\', currentPath.Length - 2);
                char[] newPath = currentPath.Take(mark).ToArray();
                StringBuilder s = new StringBuilder();

                for (int j = 0; j < newPath.Length; j++)
                {
                    s.Append(newPath[j]);
                }

                s.Append('\\');
                currentPath = s.ToString();
            }
            return currentPath;
        }
    }
}
