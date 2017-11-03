using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    class Plant : InvItem
    {
        public string Size;
        private readonly frmNewItem form = new frmNewItem();


        public Plant(int itemNo, string description, decimal price) : base(itemNo,description,price)
        {
            Size = form.sizeman;
        }
        public override string GetDisplayText()
        {
            string full = itemNo.ToString() + "    " + Size + " " + description.ToString() +  " (" + price.ToString("c") + ")";
            return full;
        }
    }
}
