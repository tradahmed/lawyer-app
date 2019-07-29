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
    public partial class userInterface : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=Avocats;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int id = 0;


        public userInterface()
        {
            InitializeComponent();
            DisplayData();
        }
        public Form RefToHome
        { get; set; }
        private void userInterface_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avocatsDataSet2.user' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.avocatsDataSet2.user);
            // TODO: This line of code loads data into the 'avocatsDataSet1.Auth' table. You can move, or remove it, as needed.
            this.authTableAdapter1.Fill(this.avocatsDataSet1.Auth);
            // TODO: This line of code loads data into the 'avocatsDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.avocatsDataSet.user);
            // TODO: This line of code loads data into the 'avocatsDataSet.Auth' table. You can move, or remove it, as needed.
            this.authTableAdapter.Fill(this.avocatsDataSet.Auth);
            NewId();

        }
        private void NewId()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Id) + 1 as Id FROM t_user", cn);
                tb1.Text = cmd.ExecuteScalar().ToString();
                cn.Close();
            }
        }

        //private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cn.Open();
        //        string qry = "SELECT Role FROM Auth";
        //        SqlDataReader dr = new SqlCommand(qry, cn).ExecuteReader();
        //        while (dr.Read())
        //        {
        //            cbox.Items.Add(dr.GetValue(0).ToString());
        //        }
        //        dr.Close();
        //    }
        //    catch (SqlException x)
        //    {
        //        MessageBox.Show(x.Message);
        //    }
        //    cn.Close();
        //}

            // inserting information into the the database 
        private void button1_Click(object sender, EventArgs e)
        {
            using (var command = cn.CreateCommand())
            {
                if 
                       ( (string.IsNullOrEmpty(tb2.Text)) ||
                            (string.IsNullOrEmpty(tb3.Text)) ||
                                ((string.IsNullOrEmpty(tb4.Text)) && (tb4.TextLength <= 8)) ||
                                   (string.IsNullOrEmpty(tb5.Text)) ||
                                       ((string.IsNullOrEmpty(tb6.Text)) && (tb4.TextLength >= 8)) ||
                                           (string.IsNullOrEmpty(tb7.Text)) ||
                                                (string.IsNullOrEmpty(tb8.Text)))
                {
                    MessageBox.Show("الرجاء ادخال جميع المعلومات");
                }
                else
                {
                    cn.Open();
                    command.CommandText = @"Insert Into t_user(nom,prenom,cin,tel,adresse) VALUES (@nom,@prenom,@cin,@tel,@adresse);
                                                                    Insert into Auth(login,pass) VALUES (@login,@pass);";
                    command.Parameters.AddWithValue("@nom", tb3.Text);
                    command.Parameters.AddWithValue("@prenom", tb2.Text);
                    command.Parameters.AddWithValue("@cin", tb4.Text);
                    command.Parameters.AddWithValue("@tel", tb6.Text);
                    command.Parameters.AddWithValue("@adresse", tb5.Text);
                    command.Parameters.AddWithValue("@login", tb7.Text);
                    command.Parameters.AddWithValue("@pass", tb8.Text);
                    command.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("تم الاضافة بنجاح");
                }
            }

        }

        //private void btview_Click(object sender, EventArgs e)
        //{
        //    cn.Open();
        //    String query = ("select b.Id, b.nom,b.prenom,a.login,a.pass from Auth a INNER join t_user b on a.id =b.Id");
        //    SqlDataAdapter da = new SqlDataAdapter(query, cn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    cn.Close();
        //}

        private void tb1_TextChanged(object sender, EventArgs e)
        {
           NewId();
        }


        // delete from data dridview where selecting a row
            private void btdel_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(tb2.Text)) ||
                 (string.IsNullOrEmpty(tb3.Text)) ||
                     ((string.IsNullOrEmpty(tb4.Text)) && (tb4.TextLength <= 8)) ||
                        (string.IsNullOrEmpty(tb5.Text)) ||
                            ((string.IsNullOrEmpty(tb6.Text)) && (tb4.TextLength >= 8)) ||
                                (string.IsNullOrEmpty(tb7.Text)) ||
                                     (string.IsNullOrEmpty(tb8.Text)))
            {
                MessageBox.Show("الرجاء التأكد من الاختيار");
            }
            else
            {
                cmd = new SqlCommand("delete from t_user where Id=@Id IN(select a.id from Auth a where Id=a.id) ", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@Id",id);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("تم الحذف بالنجاح!");
                DisplayData();
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb7.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb8.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
        //to display data in the data gridview 
        private void DisplayData()
        {
            cn.Open();
            String query = ("select b.Id, b.nom,b.prenom,a.login,a.pass from Auth a INNER join t_user b on a.id =b.Id");
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void ClearData()
        {   
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
            id = 0;
        }
        // update an information from data gridview while selecting a row
        private void btch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update t_user set b.Id=@id,b.nom=@nom,b.prenom=@prenom ,a.login=@login,a.pass=@pass from Auth a INNER join t_user b on a.id =b.Id", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@nom", tb3.Text);
            cmd.Parameters.AddWithValue("@prenom", tb2.Text);
            cmd.Parameters.AddWithValue("@cin", tb4.Text);
            cmd.Parameters.AddWithValue("@tel", tb6.Text);
            cmd.Parameters.AddWithValue("@adresse", tb5.Text);
            cmd.Parameters.AddWithValue("@login", tb7.Text);
            cmd.Parameters.AddWithValue("@pass", tb8.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            cn.Close();
            DisplayData();
            ClearData();
        }

        private void userInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToHome.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

