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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserLogin"] != null)
            {
                Response.Redirect("Admin.aspx");
            }

        }

        protected void Button_Daftar(object sender, EventArgs e)
        {
            SqlConnection RicardoConn = new SqlConnection(ConfigurationManager.ConnectionStrings["RicardoDB01Conn"].ConnectionString);
            RicardoConn.Open();
            string cekuser = "SELECT COUNT(*) FROM [User] WHERE username = '" + Username.Text + "'";
            SqlCommand query = new SqlCommand(cekuser, RicardoConn);
            int Jumlah = Convert.ToInt32(query.ExecuteScalar().ToString());
            RicardoConn.Close();

            if (Jumlah != 0)
            {
                Response.Write("Username sudah digunakan");
            }
            else
            {
                RicardoConn.Open();
                String insert = "INSERT INTO [User] (username,password,email,gender) VALUES (@username, @password, @email, @gender)";
                SqlCommand insertquery = new SqlCommand(insert, RicardoConn);
                insertquery.Parameters.AddWithValue("@username", Username.Text);
                insertquery.Parameters.AddWithValue("@password", Password.Text);
                insertquery.Parameters.AddWithValue("@email", Email.Text);
                insertquery.Parameters.AddWithValue("@gender", Gender.SelectedItem.ToString());
                insertquery.ExecuteNonQuery();
                RicardoConn.Close();

                Session["UserLogin"] = Username.Text;
                Response.Redirect("Admin.aspx");

            }


        }
    }
}