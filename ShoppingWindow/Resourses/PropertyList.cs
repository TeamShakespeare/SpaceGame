using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;


namespace ShoppingWindow.Resourses
{
    public class PropertyList
    {
        private List<PropGrid> ShipProps { get; set; }

        public PropertyList()
        {
            this.ShipProps = new List<PropGrid>();
        }

        public void Populate()
        {
            var ourList = ShoppingShip.PrepareProps();
            foreach (var p in ourList)
            {
                PropGrid pg = new PropGrid();
                pg.Fill(p);
                this.ShipProps.Add(pg);
            }
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
