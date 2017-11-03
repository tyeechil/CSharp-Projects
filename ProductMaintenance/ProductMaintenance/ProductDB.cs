using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ProductMaintenance
{
    class ProductDB : Product
    { 
       public string GetProduct()
        {
            if (Code == null) {
                return null;
            }
            else { return Code; }
        }

    }
}
