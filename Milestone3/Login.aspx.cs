using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone3
{
    public partial class Login : System.Web.UI.Page
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

        protected void login_click_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string connStr2 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn2 = new SqlConnection(connStr2);

            string connStr3 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn3 = new SqlConnection(connStr3);

            string connStr4 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn4 = new SqlConnection(connStr4);

            string connStr5 = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn5 = new SqlConnection(connStr5);


            string user = forusername.Text;
            string pass = forpassword.Text;
            SqlCommand checkForAssoc = new SqlCommand("select * from sportAssociationManager s inner join systemuser sy on s.username=sy.username where s.username = @user and password = @pass ", conn);
            SqlCommand checkForStad = new SqlCommand("select * from stadiummanager sm inner join systemuser s on sm.username=s.username where sm.username = @user  and password = @pass ", conn2);
            SqlCommand checkForRep = new SqlCommand("select * from clubrepresentative c inner join systemuser s on c.username=s.username where s.username = @user and password = @pass ", conn3);
            SqlCommand checkForFan = new SqlCommand("select * from fan f inner join systemuser s on f.username=s.username where f.username = @user and password = @pass", conn4);
            SqlCommand checkForAdmin = new SqlCommand("select * from systemadmin sa inner join systemuser s on sa.username=s.username where sa.username = @user and password = @pass", conn5);
            SqlCommand checkStatus = new SqlCommand("select f.status from fan f inner join systemuser sy on f.username =sy.username where sy.username=@user and password = @pass and f.status=0", conn4);

            checkStatus.Parameters.AddWithValue("@user", user);
            checkStatus.Parameters.AddWithValue("@pass", pass);
            checkForAssoc.Parameters.Add(new SqlParameter("@user", user));
            checkForAssoc.Parameters.Add(new SqlParameter("@pass", pass));
            checkForStad.Parameters.Add(new SqlParameter("@user", user));
            checkForStad.Parameters.Add(new SqlParameter("@pass", pass));
            checkForRep.Parameters.Add(new SqlParameter("@user", user));
            checkForRep.Parameters.Add(new SqlParameter("@pass", pass));
            checkForFan.Parameters.Add(new SqlParameter("@user", user));
            checkForFan.Parameters.Add(new SqlParameter("@pass", pass));
            checkForAdmin.Parameters.Add(new SqlParameter("@user", user));
            checkForAdmin.Parameters.Add(new SqlParameter("@pass", pass));

            conn.Open();
            SqlDataReader rd_Assoc = checkForAssoc.ExecuteReader();
            if (rd_Assoc.HasRows)
            {
                rd_Assoc.Close();
                Response.Redirect("AssocPage.aspx");
            }

            conn.Close();

            conn2.Open();
            SqlDataReader rd_stad = checkForStad.ExecuteReader();
            if (rd_stad.HasRows)
            {
                rd_stad.Close();
                Response.Redirect("StadPage.aspx");
            }
            conn2.Close();

            conn3.Open();
            SqlDataReader rd_rep = checkForRep.ExecuteReader();
            if (rd_rep.HasRows)
            {
                rd_rep.Close();
                Response.Redirect("RepPage.aspx");
            }
            conn3.Close();

            conn4.Open();
            SqlDataReader rd_status = checkStatus.ExecuteReader();
            if (rd_status.HasRows)
            {
                rd_status.Close();
                MsgBox("Sorry you are blocked from using the system", this.Page, this);
            }

            else
            {
                rd_status.Close();
                SqlDataReader rd_fan = checkForFan.ExecuteReader();
                if (rd_fan.HasRows)
                {
                    rd_fan.Close();
                    Response.Redirect("FanPage.aspx?user=" + user);
                }
            }
                conn4.Close();

                conn5.Open();
                SqlDataReader rd_admin = checkForAdmin.ExecuteReader();
                if (rd_admin.HasRows)
                {
                    rd_admin.Close();
                    Response.Redirect("AdminPage.aspx");
                }
            
            conn5.Close();

        }

        protected void Signup_click_Click(object sender, EventArgs e)
        {
            Response.Redirect("Createacc.aspx");
        }

        protected void forusername_TextChanged(object sender, EventArgs e)
        {

        }

        protected void forpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}