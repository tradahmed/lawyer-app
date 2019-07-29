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
    public partial class ListAvocat : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=Avocats;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;

        public ListAvocat()
        {
            InitializeComponent();
        }
        public Form RefToHome
        { get; set; } 
        private void ListAvocat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avocatsDataSet6.t_avocat' table. You can move, or remove it, as needed.
            this.t_avocatTableAdapter.Fill(this.avocatsDataSet6.t_avocat);
            cn.Open();
            adapt = new SqlDataAdapter("select * from t_avocat", cn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void ListAvocat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToHome.Show();

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("الاسم_اللقب LIKE '%{0}%'", tb2.Text);
            dataGridView1.DataSource = DV;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("الدائرة LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = DV;
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("العنوان LIKE '%{0}%'", tb5.Text);
            dataGridView1.DataSource = DV;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
