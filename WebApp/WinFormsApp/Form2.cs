using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{

    public partial class Form2 : Form
    {
        SqlConnection conexion = new SqlConnection("Persist Security Info=True;Initial Catalog=Mails;Data Source=.; Integrated Security=True;TrustServerCertificate=True;");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            string consulta = "Select * from UserTable where UserName = '" + txtUser.Text + "' and Password = '" + txtPassword.Text + "'";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows == true)
            {
                MessageBox.Show("Bienvenido");

                Form1 f1 =new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Error de credenciales");
            }
            conexion.Close();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
