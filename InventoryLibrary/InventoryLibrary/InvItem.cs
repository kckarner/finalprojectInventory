using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karner.Inventory
{
    public class InvItem
    {
        /// <summary>
        /// declarations for the three variables
        /// </summary>
        private int itemNo;
        private string description;
        private decimal price;

        /// <summary>
        /// Constructor that creates an instance of the InvItem class and initializes fields to default values
        /// </summary>
        public InvItem()
        {
        }

        /// <summary>
        /// Constructor that creates instance of InvItem class and initializes it with values passed to it
        /// </summary>
        /// <param name="itemNo">An int value for the item's itemNo</param>
        /// <param name="description">A string value for the item's description</param>
        /// <param name="price">A decimal value for the item's price</param>
        public InvItem(int itemNo, string description, decimal price)
        {
            this.itemNo = itemNo;
            this.description = description;
            this.price = price;
        }

        /// <summary>
        /// Declaration of the ItemNo property. Provides access to the values stored in this field
        /// </summary>
        public int ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }

        /// <summary>
        /// Declaration of the Description property. Provides access to the values stored in this field
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        /// <summary>
        /// Declaration of the Price property. Provides access to the values stored in this field
        /// </summary>
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Declaration for the GetDisplayText method, which accepts a string parameter
        /// </summary>
        /// <returns>Returns a string that concatenates the itemNo, description, and price values</returns>
        public string GetDisplayText()
        {
            return itemNo + "    " + description + " (" + price.ToString("c") + ")";
        }
    }
}

