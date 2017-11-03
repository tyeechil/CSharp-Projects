using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QALab3
{
    public partial class browse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //For debugging purposes only
            //CSVReader c = new CSVReader(); 
            //Response.Write(c.csvData);
            
        }
            protected override void OnLoad(EventArgs e)
            {
                base.OnLoad(e);
                CSVReader csv = new CSVReader();
                if (Request.QueryString["get"] != null)
                {
                    Response.Clear();
                    Response.ContentType = "application/json";
                    Response.Write(csv.csvData);
                    Response.End();
                }
            }
        }
}
