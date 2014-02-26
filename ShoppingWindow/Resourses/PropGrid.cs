using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace ShoppingWindow.Resourses
{
    /// <summary>
    /// The grid as shown in the PropertyPanel
    /// </summary>
    public class PropGrid
    {
        public string PropName { get; set; }
        public int PropValue { get; set; }

        public UIElement Render()
        {
            //The Grid field
            var container = new UniformGrid();
            container.Height = 37;
            container.Columns = 3;           

            //The PropName
            var nameField = new TextBlock();
            nameField.Text = this.PropName;
            nameField.Foreground = Brushes.White;
            nameField.Width = 172;
            nameField.Height = 27;
            nameField.Margin = new Thickness(0, 10, 0, 0);
            Grid.SetColumn(nameField, 0);

            //The PropValue
            var valueBox = new TextBox();
            valueBox.Text = this.PropValue.ToString();
            valueBox.Foreground = Brushes.White;
            valueBox.Background = Brushes.Transparent;
            valueBox.Width = 35;
            valueBox.Height = 27;
            valueBox.Margin = new Thickness(10, 10, 0, 0);
            Grid.SetColumn(valueBox, 1);

            //The Up/Down buttons
            var upButton = new Button();
            upButton.Content = "&#x25B2;";
            upButton.HorizontalAlignment = HorizontalAlignment.Right;
            upButton.VerticalAlignment = VerticalAlignment.Top;
            upButton.Height = 17;
            upButton.Width = 25;
            Grid.SetColumn(upButton, 2);
            upButton.Click += (snd, args) => this.PropValue++;

            var downButton = new Button();
            downButton.Content = "&#x25BC;";
            downButton.HorizontalAlignment = HorizontalAlignment.Right;
            downButton.VerticalAlignment = VerticalAlignment.Bottom;
            downButton.Height = 17;
            downButton.Width = 25;
            Grid.SetColumn(downButton, 2);
            downButton.Click += (snd, args) => this.PropValue--;


            return container;
        }

    }
}
