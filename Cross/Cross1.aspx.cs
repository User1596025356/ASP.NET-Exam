/*Cross1.aspx.cs*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cross1 : System.Web.UI.Page
{
    public string Name
    {
        get{ return txtName.Text; }
    }
}