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
    public partial class AssocPage : System.Web.UI.Page
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

        protected void newmatch_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string host = hostname.Text;
            string guest = guestname.Text;
            string start = startime.Text;
            DateTime time1;
            string end = endtime.Text;
            DateTime time2;
            if (!DateTime.TryParse(start, out time1) || !DateTime.TryParse(end, out time2))
            {
                MsgBox("Please enter a valid time of the match", this.Page, this);

            }
            else
            {
                time1 = DateTime.Parse(start);
                time2 = DateTime.Parse(end);
                SqlCommand addingNewMatch = new SqlCommand("addNewMatch", conn);
                addingNewMatch.CommandType = CommandType.StoredProcedure;
                addingNewMatch.Parameters.Add(new SqlParameter("@hostclubname", host));
                addingNewMatch.Parameters.Add(new SqlParameter("@guestclubname", guest));
                addingNewMatch.Parameters.Add(new SqlParameter("@start", time1));
                addingNewMatch.Parameters.Add(new SqlParameter("@end", time2));

                conn.Open();
                addingNewMatch.ExecuteNonQuery();
                conn.Close();
            }
        }

        protected void startinfo(object sender, EventArgs e)
        {

        }

        protected void endtimeinfo(object sender, EventArgs e)
        {

        }

        protected void deletematch_Click(object sender, EventArgs e)
        {
            string connStr2 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn2 = new SqlConnection(connStr2);

            string host = hostname_delete.Text;
            string guest = guestname_delete.Text;
            string start = startime_delete.Text;
            DateTime time1;
            string end = endtime_delete.Text;
            DateTime time2;
            if (!DateTime.TryParse(start, out time1) || !DateTime.TryParse(end, out time2))
            {
                MsgBox("Please enter a valid time of the match", this.Page, this);

            }
            else
            {
                time1 = DateTime.Parse(start);
                time2 = DateTime.Parse(end);
                SqlCommand DeletingMatch = new SqlCommand("deleteMatch", conn2);
                DeletingMatch.CommandType = CommandType.StoredProcedure;
                DeletingMatch.Parameters.Add(new SqlParameter("@hostclubname", host));
                DeletingMatch.Parameters.Add(new SqlParameter("@guestclubname", guest));
                DeletingMatch.Parameters.Add(new SqlParameter("@start", time1));
                DeletingMatch.Parameters.Add(new SqlParameter("@end", time2));

                conn2.Open();
                DeletingMatch.ExecuteNonQuery();
                conn2.Close();
            }
        }

        protected void hostname_delete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void viewMatches_Click(object sender, EventArgs e)
        {
            string connStr3 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn3 = new SqlConnection(connStr3);

            string s = forclubnames.Text;
            SqlCommand cmd = new SqlCommand("select * from dbo.upcomingMatchesOfClub(@s)", conn3);

            cmd.Parameters.AddWithValue("@s", s);

            conn3.Open();

             SqlDataReader reader = cmd.ExecuteReader();
             GridView4.DataSource = reader;
             GridView4.DataBind();
             conn3.Close();

        }
    }
}