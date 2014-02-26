using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace ShoppingWindow.Resourses
{
    class PropertyList
    {
        private List<PropGrid> ShipProps { get; set; }

        public PropertyList()
        {
            this.ShipProps = new List<PropGrid>();
        }

        public void Populate()
        {

        }

        public UIElement Render()
        {
            var list = new ListBox();

            foreach (var shipProp in this.ShipProps)
	        {
		        var renderedPropGrid = shipProp.Render();

                var propertyListItem = new ListBoxItem();
                propertyListItem.Content = renderedPropGrid;
                list.Items.Add(propertyListItem);
	        }

            return list;
        }
    }
}
