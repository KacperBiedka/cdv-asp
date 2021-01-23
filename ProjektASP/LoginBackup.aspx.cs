using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ProjektASP
{
    public partial class Login : System.Web.UI.Page
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnLogin_Click(object sender, EventArgs e) {
            try {
                SqlConnection con = new SqlConnection(connectionString);
                string commandText = "SELECT * FROM users WHERE (UserName = @username) and (Password = @password)";
                SqlCommand cmd = new SqlCommand(commandText, con);
                cmd.Parameters.AddWithValue("@username", txtUserId.Text.ToString());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.ToString());
                txtInfo.Text = txtPassword.Text.ToString();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    Session["UserName"] = txtUserId.Text.ToString();
                    txtInfo.Text = "Login successful!";
                    reader.Close();
                    con.Close();

                    Response.Redirect("~/Dashboard.aspx");
                } else {
                    txtInfo.Text = "Nie znaleziono użytkownika";
                }
                reader.Close();
                con.Close();
            } catch (Exception ex) {
                txtInfo.Text = ex.ToString();
            }
        }
    }
}