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
    public partial class SportAssoc : System.Web.UI.Page
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

        protected void Register(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string NameOfAssoc = Name.Text;
            string user = Username.Text;
            string pass = Password.Text;

            SqlCommand addingNewAssoc = new SqlCommand("addAssociationManager", conn);
            addingNewAssoc.CommandType = CommandType.StoredProcedure;
            addingNewAssoc.Parameters.Add(new SqlParameter("@name", NameOfAssoc));
            addingNewAssoc.Parameters.Add(new SqlParameter("@username", user));
            addingNewAssoc.Parameters.Add(new SqlParameter("@password", pass));

            SqlCommand check = new SqlCommand("select * from systemuser where username = @user ", conn);
            check.Parameters.Add(new SqlParameter("@user", user));

            conn.Open();
            SqlDataReader rd = check.ExecuteReader();
            if (NameOfAssoc.ToString() == "" || user.ToString() == "" || pass.ToString() == "")
                MsgBox("You can't enter an empty information of yourself", this.Page, this);
            else
            {
                if (rd.HasRows)
                    MsgBox("This username already exists, Please enter a new one", this.Page, this);
                else
                {
                    rd.Close();
                    addingNewAssoc.ExecuteNonQuery();
                    Response.Redirect("Login.aspx");
                }
                conn.Close();
            }


        }
        
    }
}