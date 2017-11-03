using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    class Supply : InvItem
    {
        public string Manufacturer;
        private readonly frmNewItem form;

        public Supply(frmNewItem form)
        {
            this.form = form;
        }

        public Supply(int itemNo, string description, decimal price) : base(itemNo,description,price)
        {
            Manufacturer = form.sizeman;
        }
        public override string GetDisplayText()
        {
            string full = itemNo.ToString() + "    " + Manufacturer + " " + description.ToString() + " (" + price.ToString("c") + ")";
            return full;
        }
    }
}
