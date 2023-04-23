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
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addingclub_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string clubname = forname.Text;
            string location = forlocation.Text;

            SqlCommand addingclub = new SqlCommand("addClub", conn);
            addingclub.CommandType = CommandType.StoredProcedure;
            addingclub.Parameters.Add(new SqlParameter("@nameclub",clubname));
            addingclub.Parameters.Add(new SqlParameter("@location", location));

            conn.Open();
            addingclub.ExecuteNonQuery();
            conn.Close();
        }

        protected void addingstadium_Click(object sender, EventArgs e)
        {
            string connStr2 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn2 = new SqlConnection(connStr2);

            string stadiumname = forname0.Text;
            string location = forlocation0.Text;
            string cap = forcapacity.Text;
            int capacity = int.Parse(cap);

            SqlCommand addingstadium = new SqlCommand("addStadium", conn2);
            addingstadium.CommandType = CommandType.StoredProcedure;
            addingstadium.Parameters.Add(new SqlParameter("@namestadium", stadiumname));
            addingstadium.Parameters.Add(new SqlParameter("@location", location));
            addingstadium.Parameters.Add(new SqlParameter("@capacity", capacity));

            conn2.Open();
            addingstadium.ExecuteNonQuery();
            conn2.Close();
        }

        protected void deletingclub_Click(object sender, EventArgs e)
        {
            string connStr3 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn3 = new SqlConnection(connStr3);
            string clubname = fordeleteclub.Text;

            SqlCommand deletingclub = new SqlCommand("deleteClub", conn3);
            deletingclub.CommandType = CommandType.StoredProcedure;
            deletingclub.Parameters.Add(new SqlParameter("@nameclub", clubname));

            conn3.Open();
            deletingclub.ExecuteNonQuery();
            conn3.Close();



        }

        protected void deletingstad_Click(object sender, EventArgs e)
        {
            string connStr4 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn4 = new SqlConnection(connStr4);
            string stadiumname = fordeletestadium.Text;

            SqlCommand deletingstad = new SqlCommand("deleteStadium", conn4);
            deletingstad.CommandType = CommandType.StoredProcedure;
            deletingstad.Parameters.Add(new SqlParameter("@namestadium", stadiumname));

            conn4.Open();
            deletingstad.ExecuteNonQuery();
            conn4.Close();
        }

        protected void blockfan_Click(object sender, EventArgs e)
        {
            
            string connStr5 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn5 = new SqlConnection(connStr5);
            string id = forBlock.Text;

            SqlCommand blockingfan = new SqlCommand("blockFan", conn5);
            blockingfan.CommandType = CommandType.StoredProcedure;
            blockingfan.Parameters.Add(new SqlParameter("@nationalid", id));

            conn5.Open();
            blockingfan.ExecuteNonQuery();
            conn5.Close();

        }
    }
}