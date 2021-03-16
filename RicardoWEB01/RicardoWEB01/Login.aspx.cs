using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace RicardoWEB01
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserLogin"] != null)
            {
                Response.Redirect("Admin.aspx");
            }

        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection RicardoConn = new SqlConnection(ConfigurationManager.ConnectionStrings["RicardoDB01Conn"].ConnectionString);
            RicardoConn.Open();
            string cekuser = "SELECT COUNT(*) FROM [User] WHERE username = '" + UserLogin.Text + "'";
            SqlCommand query = new SqlCommand(cekuser, RicardoConn);
            int Jumlah = Convert.ToInt32(query.ExecuteScalar().ToString());
            RicardoConn.Close();

            if (Jumlah == 1)
            {
                RicardoConn.Open();
                string passwordsql = "SELECT password FROM [user] WHERE username='" + UserLogin.Text + "' ";
                SqlCommand passquery = new SqlCommand(passwordsql, RicardoConn);
                string password = passquery.ExecuteScalar().ToString();
                RicardoConn.Close();

                if (password == PassLogin.Text)
                {
                    Session["UserLogin"] = UserLogin.Text;
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    Response.Write("Password salah!");
                    UserLogin.Text = "";
                }
            }

            else
            {
                Response.Write("Username tidak ditemukan ");
                UserLogin.Text = "";
            }
        }
    }
}