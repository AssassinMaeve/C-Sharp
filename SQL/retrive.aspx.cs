using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataClasses1DataContext ds = new DataClasses1DataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["username"] == null)
            //{
              //  Response.Redirect("login.aspx");
            //}
        }

        private void getData()
        {

            
            string[] fruits = { "Apple", "Banana", "Orange", "Grapes", "Mango" };

            // Query Expression Syntax
            var result = from frt in fruits
                         where frt.Length > 5
                         select frt;

            // Products in a class
            GridView1.DataSource = ds.Products;
            GridView1.DataSource = from pro in ds.Products select pro;
            GridView1.DataBind();
        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            getData();
        }

        // Inserting items in the gridView
        protected void Button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Productname = "delmouse";
            product.Price = 500;
            ds.Products.InsertOnSubmit(product);
            Response.Write(ds.GetChangeSet().Inserts.Count);

            // Without SubmitChanges nothing will be inserted
            ds.SubmitChanges();
            getData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Confirm.aspx?Pid=3");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Add the correct pid or it will throw an exception
            Product product = (from x in ds.Products where x.Pid == 3 select x).Single();
            product.Price = 700;
            ds.SubmitChanges();
            getData();
        }
    }
}