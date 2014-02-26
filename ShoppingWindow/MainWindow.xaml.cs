using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowSwitch;
using ShoppingWindow.Resourses;

namespace ShoppingWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PropertyList wholeList = new PropertyList();
        public MainWindow()
        {
            InitializeComponent();
            this.RenderProps();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {            
            Utilities.SwitchToConsole();
        }

        private void RenderProps()
        {
            this.PropetrtyPanel.Children.Clear();
            wholeList.Populate();            
            this.PropetrtyPanel.Children.Add(this.wholeList.Render());
        }
    }
}
