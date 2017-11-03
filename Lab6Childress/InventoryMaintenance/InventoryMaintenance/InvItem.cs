using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public static int itemNo;
        public static string description;
        public static decimal price;

        public InvItem()
        {
        }

        public InvItem(int itemNo, string description, decimal price)
        {
            

        }
       
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
        
        public virtual string GetDisplayText()
        {
            string full  = itemNo.ToString() + "    " + description.ToString() + " (" + price.ToString("c") + ")";
            return full;

        }
    }
}
