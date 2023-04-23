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
    public partial class ClubRep : System.Web.UI.Page
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

        protected void Register_rep_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string NameOfRep = forname.Text;
            string user = forusername.Text;
            string pass = forpassword.Text;
            string clubname = listofclubs.Text;
            SqlCommand addingNewRep = new SqlCommand("addRepresentative", conn);
            addingNewRep.CommandType = CommandType.StoredProcedure;
            addingNewRep.Parameters.Add(new SqlParameter("@namerep", NameOfRep));
            addingNewRep.Parameters.Add(new SqlParameter("@nameclub", clubname));
            addingNewRep.Parameters.Add(new SqlParameter("@username", user));
            addingNewRep.Parameters.Add(new SqlParameter("@password", pass));

            SqlCommand check = new SqlCommand("select * from systemuser where username = @user ", conn);
            check.Parameters.Add(new SqlParameter("@user", user));

            conn.Open();
            SqlDataReader rd = check.ExecuteReader();

            if (NameOfRep.ToString() == "" || user.ToString() == "" || pass.ToString() == "")
                MsgBox("You can't enter an empty information of yourself", this.Page, this);

            else
            {
                if (rd.HasRows)
                    MsgBox("This username already exists, Please enter a new one", this.Page, this);
                else
                {
                    rd.Close();
                    addingNewRep.ExecuteNonQuery();
                    Response.Redirect("Login.aspx");
                }
                conn.Close();
            }
        }
    }
}