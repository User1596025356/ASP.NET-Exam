using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class LinqXml : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnCreate_Click(object sender, EventArgs e)
    {
        string xmlFilePath = Server.MapPath("~/BookLinq.xml");

        XDocument doc = new XDocument
        (
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("Book示例"),
            new XElement("Books",
                new XElement("Book",
                    new XAttribute("ID", "100"),
                    new XElement("BookName", "ASP.NET高级编程"),
                    new XElement("Price", 156)
                ),
            new XElement("Book",
                new XAttribute("ID", "101"),
                new XElement("BookName", "精通LINQ数据访问"),
                new XElement("Price", 39.8)
                ),
            new XElement("Book",
                new XAttribute("ID", "102"),
                new XElement("BookName", "ASP.NET教程"),
                new XElement("Price", 41.6)
                )
            )
        );
        doc.Save(xmlFilePath);
        Response.Redirect("~/BookLinq.xml");
    }
}