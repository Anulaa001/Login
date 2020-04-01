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
    public partial class Logowanie : Form
           
        
     
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }


        //Connection String
        string cs = @"Data Source=DESKTOP-I0P7JDH\SQLEXPRESS;Initial Catalog=logowanie;Integrated Security=True";
        private void zaloguj_Click(object sender, EventArgs e)
        {
            string Uzytkownik = this.Username.Text;
            string haslo = this.Password.Text;
            /*
            if(sprawdzenieHasla(Uzytkownik,haslo))
            {

                MessageBox.Show("Zostałeś zalogowany pomyślnie!");
            }
            else
                MessageBox.Show("Błąd logowanie");
                */
            //Create SqlConnection
            
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Register where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", Username.Text);
                cmd.Parameters.AddWithValue("@password", Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    

                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            
           

        }
        
        private bool sprawdzenieHasla(string uzytkownik,string haslo)
        {
            if (uzytkownik == "Andrzej" & haslo == "andrzej")
                return true;
            else
                return false;
                
        }

        private void rejestracja_Click(object sender, EventArgs e)
        {
            
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
