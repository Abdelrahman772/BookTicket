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
    public partial class StadManager : System.Web.UI.Page
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

        protected void registerclicked_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string name = forname.Text;
            string user = forusername.Text;
            string pass = forpassword.Text;
            string stad = forstad.Text;        

            SqlCommand addNewStadiumManager = new SqlCommand("addStadiumManager", conn);
            addNewStadiumManager.CommandType = CommandType.StoredProcedure;
            addNewStadiumManager.Parameters.Add(new SqlParameter("@name", name));
            addNewStadiumManager.Parameters.Add(new SqlParameter("@namestadium", stad));
            addNewStadiumManager.Parameters.Add(new SqlParameter("@username", user));
            addNewStadiumManager.Parameters.Add(new SqlParameter("@password", pass));


            SqlCommand check = new SqlCommand("select * from systemuser where username = @user ", conn);
            check.Parameters.Add(new SqlParameter("@user", user));

            conn.Open();
            SqlDataReader rd = check.ExecuteReader();

            if (name.ToString() == "" || user.ToString() == "" || pass.ToString() == "")
                MsgBox("You can't enter an empty information of yourself", this.Page, this);

            else
            {


                if (rd.HasRows)
                    MsgBox("This username already exists, Please enter a new one", this.Page, this);
                else
                {
                    rd.Close();
                    addNewStadiumManager.ExecuteNonQuery();
                    Response.Redirect("Login.aspx");
                }
                conn.Close();
            }
        }
    }
}