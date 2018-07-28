using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hackathon
{
    public partial class Profile : Page
    {
        //public static string phone { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {


            var phone = Request.QueryString["phone"];
            testt.Text = phone;
            userPhone.Value = phone;
            
            
        }
        
        
    }
}