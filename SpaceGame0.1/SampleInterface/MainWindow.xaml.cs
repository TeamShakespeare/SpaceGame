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

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Process consoleProcess = new Process();
            string processPath = System.IO.Path.Combine(Misc.stepOut(3), @"Try1\bin\Debug\Try1.exe");
            consoleProcess.StartInfo.FileName = processPath;
            
            consoleProcess.Start();
            Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
