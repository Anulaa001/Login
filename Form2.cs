using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace logowanie
{
    public partial class Rejestracja : Form
    {
        //Connection String
        string cs = @"Data Source=DESKTOP-I0P7JDH\SQLEXPRESS;Initial Catalog=logowanie;Integrated Security=True";
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void Rejestraja_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ID_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void zarejestruj_sie_Click(object sender, EventArgs e)
        {
            
            string username = username_rejestr.Text;
            string email = email_rejestr.Text;
            string haslo = haslo_rejestr.Text;

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into Register values (@username,@password,@email)", con);
            cmd.Parameters.AddWithValue("@username", username_rejestr.Text);
            cmd.Parameters.AddWithValue("@email", email_rejestr.Text);
            cmd.Parameters.AddWithValue("@password", haslo_rejestr.Text);
            
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            MessageBox.Show("Zastałeś zarejestrowany");
        }
    }
}
