using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone3
{
    public partial class FanPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        protected void purchase_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string id = for_id.Text;
            string host = forhost.Text;
            string guest = forguest.Text;
            string t = fortime.Text;
            DateTime time;
            if (!DateTime.TryParse(t, out time))
            {
                MsgBox("Please enter a correct time about the match", this.Page, this);
            }
            else
            {
                time = DateTime.Parse(t);
                SqlCommand purchase = new SqlCommand("purchaseTicket", conn);
                purchase.CommandType = CommandType.StoredProcedure;

                purchase.Parameters.Add(new SqlParameter("@nationalID", id));
                purchase.Parameters.Add(new SqlParameter("@hostclubname", host));
                purchase.Parameters.Add(new SqlParameter("@guestclubname", guest));
                purchase.Parameters.Add(new SqlParameter("@startime", time));


                conn.Open();
                purchase.ExecuteNonQuery();
                conn.Close();
            }

        }
    }
}