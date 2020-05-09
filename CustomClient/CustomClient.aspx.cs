using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomClient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //书上代码没有这句
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            lblMsg.Text = "验证通过！";
        }
    }
}