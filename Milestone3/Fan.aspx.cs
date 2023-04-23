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
    public partial class Fan : System.Web.UI.Page
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

        protected void register_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["project_db"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string namefan = forname.Text;
            string user = forusername.Text;
            string pass = forpassword.Text;
            string id = for_id.Text;
            string phone = forphone.Text;
            int p1 = int.Parse(phone);
            string bd = for_birthdate.Text;
            DateTime bd1;
            string address = foraddress.Text;
            if (!DateTime.TryParse(bd, out bd1))
            {
                MsgBox("Please enter a correct information about yourself", this.Page, this);

            }
            else
            {
                bd1 = DateTime.Parse(bd);

                SqlCommand addNewFan = new SqlCommand("addFan", conn);
                addNewFan.CommandType = CommandType.StoredProcedure;
                addNewFan.Parameters.Add(new SqlParameter("@name", namefan));
                addNewFan.Parameters.Add(new SqlParameter("@username", user));
                addNewFan.Parameters.Add(new SqlParameter("@password", pass));
                addNewFan.Parameters.Add(new SqlParameter("@nationalid", id));
                addNewFan.Parameters.Add(new SqlParameter("@birthdate", bd1));
                addNewFan.Parameters.Add(new SqlParameter("@address", address));
                addNewFan.Parameters.Add(new SqlParameter("@phonenumber", p1));

                SqlCommand check = new SqlCommand("select * from systemuser where username = @user ", conn);
                check.Parameters.Add(new SqlParameter("@user", user));

                conn.Open();
                SqlDataReader rd = check.ExecuteReader();

                if (namefan.ToString() == "" || user.ToString() == "" || pass.ToString() == "" || id.ToString() == "" || phone.ToString() == "" || address.ToString() == "" )
                    MsgBox("Please enter a correct information about yourself", this.Page, this);

                else
                {
                    if (rd.HasRows)
                        MsgBox("This username already exists, Please enter a new one", this.Page, this);
                    else
                    {
                        rd.Close();
                        addNewFan.ExecuteNonQuery();
                        Response.Redirect("Login.aspx");
                    }


                }
                conn.Close();
            }
        }
    }
}