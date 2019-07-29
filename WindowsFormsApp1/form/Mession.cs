using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.form
{
    public partial class Mession : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=Avocats;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Mession()
        {
            InitializeComponent();
        }
        public Form RefToHome
        { get; set; }
        private void Mession_Load(object sender, EventArgs e)
        {

        }

        private void Mession_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToHome.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into mession(id,objet,description,person) VALUES (@id,@objet,@description,'"+cb1.SelectedItem.ToString()+"')", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@objet", tb1.Text);
            cmd.Parameters.AddWithValue("@description", rtb);
            cmd.ExecuteNonQuery();
            cn.Close();


        }
    }
}
