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
    public partial class StadPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr2 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn2 = new SqlConnection(connStr2);

            string s = forusername.Text;
            SqlCommand cmd_requests = new SqlCommand("select * from dbo.allPendingRequests(@s)", conn2);

            cmd_requests.Parameters.AddWithValue("@s", s);

            conn2.Open();
            SqlDataReader reader2 = cmd_requests.ExecuteReader();
            Requests.DataSource = reader2;
            Requests.DataBind();
            conn2.Close();
        }
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        protected void acceptingclick_Click(object sender, EventArgs e)
        {
            string connStr2 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn2 = new SqlConnection(connStr2);

            string user = managerusername.Text;
            string host = hostname.Text;
            string guest = guestname.Text;
            string t = timeofmatch.Text;
            DateTime time;
            if (!DateTime.TryParse(t, out time))
            {
                MsgBox("Please enter a correct startime about the request", this.Page, this);
            }
            else
            {
                time = DateTime.Parse(t);

                SqlCommand accepting = new SqlCommand("acceptRequest", conn2);
                accepting.CommandType = CommandType.StoredProcedure;
                accepting.Parameters.Add(new SqlParameter("@username", user));
                accepting.Parameters.Add(new SqlParameter("@namehostclub", host));
                accepting.Parameters.Add(new SqlParameter("@nameguestclub", guest));
                accepting.Parameters.Add(new SqlParameter("@startime", time));

                conn2.Open();
                accepting.ExecuteNonQuery();
                conn2.Close();
            }
        }

        protected void viewclick_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string user = forusername.Text;
            SqlCommand cmd = new SqlCommand("select * from dbo.InfoStad(@user)", conn);

            cmd.Parameters.AddWithValue("@user", user);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            stad.DataSource = reader;
            stad.DataBind();
            conn.Close();
        }

        protected void rejectingclick_Click(object sender, EventArgs e)
        {
            string connStr3 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn3 = new SqlConnection(connStr3);

            string user1 = managerusername0.Text;
            string host1 = hostname0.Text;
            string guest1 = guestname0.Text;
            string t1 = timeofmatch0.Text;
            DateTime time1;
            if (!DateTime.TryParse(t1, out time1))
            {
                MsgBox("Please enter a correct startime about the request", this.Page, this);
            }
            else
            {
                time1 = DateTime.Parse(t1);
                SqlCommand rejecting = new SqlCommand("rejectRequest", conn3);
                rejecting.CommandType = CommandType.StoredProcedure;
                rejecting.Parameters.Add(new SqlParameter("@username", user1));
                rejecting.Parameters.Add(new SqlParameter("@namehostclub", host1));
                rejecting.Parameters.Add(new SqlParameter("@nameguestclub", guest1));
                rejecting.Parameters.Add(new SqlParameter("@startime", time1));

                conn3.Open();
                rejecting.ExecuteNonQuery();
                conn3.Close();
            }
        }
    }
}