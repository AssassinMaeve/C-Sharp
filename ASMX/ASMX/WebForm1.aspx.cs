using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASMX.ServiceReference2;

namespace ASMX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            WebService1 service1 = new WebService1();
            int a = Convert.ToInt32(NumBox1.Text);
            int b = Convert.ToInt32(NumBox2.Text);
            int result = service1.Add(a,b);
            Label1.Text = result.ToString();
        }
        protected void SubButton_Click(object sender, EventArgs e)
        {
            WebService1 service1 = new WebService1();
            int a = Convert.ToInt32(NumBox1.Text);
            int b = Convert.ToInt32(NumBox2.Text);
            int result = service1.Sub(a,b);
            Label1.Text = result.ToString();

        }

        protected void MulButton_Click(object sender, EventArgs e)
        {
            // This is one method to call the web service using the connected service reference
            WebService1SoapClient service1 = new WebService1SoapClient();
            int a = Convert.ToInt32(NumBox1.Text);
            int b = Convert.ToInt32(NumBox2.Text);
            int result = service1.Mul(a,b);
            Label1.Text = result.ToString();

        }

        protected void DivButton_Click(object sender, EventArgs e)
        {
            // This is another method to call the web service using the connected service reference
            ServiceReference2.WebService1SoapClient service1 = new ServiceReference2.WebService1SoapClient();
            int a = Convert.ToInt32(NumBox1.Text);
            int b = Convert.ToInt32(NumBox2.Text);
            int result = service1.Div(a,b);
            Label1.Text = result.ToString();

        }
    }
}