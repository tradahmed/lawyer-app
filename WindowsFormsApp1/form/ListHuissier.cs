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
    public partial class ListHuissier : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=Avocats;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;

        public ListHuissier()
        {
            InitializeComponent();
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            //cn.Open();
            //adapt = new SqlDataAdapter("select * from ListeHJ WHERE الاسم LIKE '%'" +  tb2.Text  +"'%'", cn);
            //dt = new DataTable();
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //cn.Close();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("الاسم LIKE '%{0}%'", tb2.Text);
            dataGridView1.DataSource = DV;
        }
        public Form RefToHome
        { get; set; }
        private void ListHuissier_Load(object sender, EventArgs e)
        {
            cn.Open();
            adapt = new SqlDataAdapter("select * from ListeHJ", cn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void ListHuissier_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToHome.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("الولاية LIKE '%{0}%'", tb1.Text);
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
