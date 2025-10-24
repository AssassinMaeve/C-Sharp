using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQL
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataClasses1DataContext ds = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("retrive.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Deleting using HyperLink
            Product product = new Product();
            product = ds.Products.SingleOrDefault(td => td.Pid == Convert.ToInt32(Request.QueryString["Pid"]));
            product = (from ts in ds.Products where ts.Pid == int.Parse(Request.QueryString["Pid"]) select ts).Single();

            ds.Products.DeleteOnSubmit(product);
            ds.SubmitChanges();
            Response.Redirect("retrive.aspx");



            //Product product = ds.Products.SingleOrDefault(p => p.Pid == 3);
            //ds.Products.DeleteOnSubmit(product);
            //ds.SubmitChanges();
            //Response.Redirect("retrive.aspx");
        }
    }
}