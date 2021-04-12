using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmStandardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblDateTime.Text = DateTime.Now.ToString();
        }

        protected void BtnServer_Click(object sender, EventArgs e)
        {

        }
    }
}