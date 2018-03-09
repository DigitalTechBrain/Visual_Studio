using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpDemo
{
    public partial class Default : System.Web.UI.Page
    {
        struct Book
        {
            public int a;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Book book1;
            book1.a = 2;

            Response.Write(book1.a);
            
        }
    }
}