using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfServiceWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Service1.Service1Client client = new Service1.Service1Client();
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = client.GetMessage(TextBox1.Text);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Service1.Person person = client.GetPerson(new Service1.Person { FirstName = TextBox2.Text , LastName = TextBox3.Text});
            Label2.Text = person.FirstName;
            Label3.Text = person.LastName;
        }


    }
}