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
    public partial class rapport : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=Avocats;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public rapport()
        {
            InitializeComponent();
        }

        private void rapport_Load(object sender, EventArgs e)
        {

        }
        public Form RefToHome
        { get; set; } 

        private void rapport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToHome.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
