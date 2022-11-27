using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge6
{
    public partial class Test : System.Web.UI.Page
    {
        BAL.DesignationBAL objdptbl = new BAL.DesignationBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            string _id = Request.QueryString["desigId"].ToString();

            DataTable dt = objdptbl.viewDesgn();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((dt.Rows[i]["desigId"].ToString() == _id))
                {
                    Label2.Text = dt.Rows[i]["desigId"].ToString();
                    Label4.Text = dt.Rows[i]["desigName"].ToString();
                }
            }
        }
    }
}
