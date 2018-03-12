using AustinHarris.JsonRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JsonRpc
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }

    public class HelloWorldService : JsonRpcService
    {
        [JsonRpcMethod]
        private string helloWorld(string message)
        {
            return "Hello World " + message;
        }
    }
}