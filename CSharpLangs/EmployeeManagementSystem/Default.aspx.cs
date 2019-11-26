using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class _Default : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            Session["Name"] = TextBoxName.Text;
            Response.Redirect("Welcome.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}