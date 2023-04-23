using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone3
{
    public partial class Createacc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SportAssoc.aspx");
        }

        protected void Clubrep_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClubRep.aspx");
        }

        protected void stadManager_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("StadManager.aspx");
        }

        protected void Fan_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fan.aspx");
        }
    }
}