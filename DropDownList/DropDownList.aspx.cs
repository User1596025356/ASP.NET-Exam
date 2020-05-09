using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropDownList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindYear();
        BindMonth();
        BindDay();
    }
    protected void BindYear()
    {
        ddlYear.Items.Clear();
        int startYear = DateTime.Now.Year - 10;
        int currentYear = DateTime.Now.Year;
        for(int i = startYear; i <= currentYear; i++)
        {
            ddlYear.Items.Add(new ListItem(i.ToString()));
        }
        ddlYear.SelectedValue = currentYear.ToString();
    }
    protected void BindMonth()
    {
        ddlMonth.Items.Clear();
        for(int i = 1; i <= 12; i++)
        {
            ddlMonth.Items.Add(i.ToString());
        }
    }
    protected void BindDay()
    {
        ddlDay.Items.Clear();
        string year = ddlYear.SelectedValue;
        string month = ddlMonth.SelectedValue;
        int days = DateTime.DaysInMonth(int.Parse(year), int.Parse(month));
        for(int i = 1; i <= days; i++)
        {
            ddlDay.Items.Add(i.ToString());
        }
    }
    protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDay();
    }
    protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDay();
    }
}