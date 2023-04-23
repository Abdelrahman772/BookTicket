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
    public partial class RepPage : System.Web.UI.Page
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

        protected void infoclub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       protected void onview_Click(object sender, EventArgs e)
        {
             string connStr2 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
             SqlConnection conn2 = new SqlConnection(connStr2);

             string t = fortime.Text;
             DateTime time;
            if (!DateTime.TryParse(t,out time))
            {
                MsgBox("Please enter a correct time to see the available stadiums", this.Page, this);

            }
            else
            {
                time = DateTime.Parse(t);
                SqlCommand cmd = new SqlCommand("select * from dbo.viewAvailableStadiumsOn(@date)", conn2);

                cmd.Parameters.AddWithValue("@date", time);

                conn2.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                availablestadiums.DataSource = reader;
                availablestadiums.DataBind();
                conn2.Close();
            }
             
        }

        protected void clicktoseeinfo_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string user = forusername.Text;
            SqlCommand cmd = new SqlCommand("select * from dbo.InfoClub(@user)", conn);

            cmd.Parameters.AddWithValue("@user", user);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            infoclub.DataSource = reader;
            infoclub.DataBind();
            conn.Close();
        }

        protected void requestClick_Click(object sender, EventArgs e)
        {
            string connStr3 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn3 = new SqlConnection(connStr3);

            string name = forclubnames.Text;
            string stad = forstadnames.Text;
            string t = forstartime.Text;
            DateTime time;
            if (!DateTime.TryParse(t, out time))
            {
                MsgBox("Please enter a correct time in your request", this.Page, this);

            }
            else
            {
                time = DateTime.Parse(t);

                SqlCommand addrequest = new SqlCommand("addHostRequest", conn3);
                addrequest.CommandType = CommandType.StoredProcedure;

                addrequest.Parameters.Add(new SqlParameter("@nameclub", name));
                addrequest.Parameters.Add(new SqlParameter("@namestadium", stad));
                addrequest.Parameters.Add(new SqlParameter("@startime", time));

                conn3.Open();
                addrequest.ExecuteNonQuery();
                conn3.Close();
            }
        }

        protected void upcomingmatches_Click(object sender, EventArgs e)
        {
            string connStr4 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn4 = new SqlConnection(connStr4);

            string name = nameoftheclub.Text;
            SqlCommand cmd = new SqlCommand("select * from dbo.upcomingMatchesOfClub2(@nameclub)", conn4);

            cmd.Parameters.AddWithValue("@nameclub", name);

            conn4.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            matchesoftheclub.DataSource = reader;
            matchesoftheclub.DataBind();
            conn4.Close();
        }
    }
    }