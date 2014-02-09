using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Finds a path, a number of levels above the current one, so that another directory in the same solution can be accessed
        /// </summary>
        /// <param name="directoriesCount">The number of directories to step out of.</param>
        /// <returns></returns>
        private string stepOut(int directoriesCount)
        {
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;

            for (int i = 0; i < directoriesCount; i++)
            {
                int mark = currentPath.LastIndexOf('\\',currentPath.Length - 2);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Process consoleProcess = new Process();
            string processPath = System.IO.Path.Combine(stepOut(3), @"Try1\bin\Debug\Try1.exe");
            consoleProcess.StartInfo.FileName = processPath;
            Process.Start(processPath);
        }
    }
}
