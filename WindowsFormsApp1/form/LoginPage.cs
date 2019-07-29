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

namespace WindowsFormsApp1
{
    public partial class Welcome : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=Avocats;Integrated Security=True");
        SqlCommand cmd;
        static int attempt = 3;

        public Welcome()
        {
            InitializeComponent();
        }

        private void Reset(object sender, EventArgs e)
        {
            tb1.ResetText();
            tb2.ResetText();
        }


        //private void Welcome_Load(object sender, EventArgs e)
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

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                if (attempt == 0)
                {
                    lbl_Msg.Text = ("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");
                    tb1.Enabled = false;
                    tb2.Enabled = false;
                    tb1.Clear();
                    tb2.Clear();
                    return;
                }
                cmd = new SqlCommand("select count(*) from Auth where login=@login and pass=@pass", cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@login", tb1.Text);
                cmd.Parameters.AddWithValue("@pass", tb2.Text);
                cn.Open();

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    errorlogin.Icon = Properties.Resources.ok;
                    errorlogin.SetError(tb1, "تم");
                    errorpass.Icon = Properties.Resources.ok;
                    errorpass.SetError(tb2, "تم");
                    MessageBox.Show(" تم الدخول بنجاح ");
                    this.Hide();
                    var sh = new Home(tb1.Text + "  :مرحبا  ");
                    sh.Closed += (s, args) => this.Close();
                    sh.Show();

                }

                //    cmd SelectCommand = new MySqlCommand("Select role form Auth", cn);
                //    DataTable dt = new DataTable();
                //    sda.Fill(dt);
                //    if (dt.Rows.Count == 1)
                //    { 
                //        this.Hide();
                //        var sh = new Home(tb1.Text + "  :مرحبا  ");
                //        sh.Closed += (s, args) => this.Close();
                //        sh.Show();
                //    }else
                //    {
                //        this.Hide();
                //        var sh1 = new Home1(tb1.Text + "  :مرحبا  ");
                //        sh1.Closed += (s, args) => this.Close();
                //        sh1.Show();
                //    }
                //}

                else
                        {
                            errorlogin.Icon = Properties.Resources.err;
                            errorlogin.SetError(tb1, "خطأ في اسم المستخدم");
                            errorpass.Icon = Properties.Resources.err;
                            errorpass.SetError(tb2, "خطأ في  كلمة المرور");
                            MessageBox.Show("  لا يمكن الدخول \n الرجاء اعادة اسم المستخدم و كلمة السر ");
                            lbl_Msg.Text = (" لديك فقط  " + Convert.ToString(attempt) + "  محاولات للاعادة ");
                            --attempt;
                            tb1.Clear();
                            tb2.Clear();
                        }
                        cn.Close();



                    }
                    catch
                    {
                        //nothing here
                    }


        }

                private void tb1_Leave(object sender, EventArgs e)
                {
                    if (string.IsNullOrEmpty(tb1.Text))
                    {
                        errorlogin.Icon = Properties.Resources.err;
                        errorlogin.SetError(tb1, "Login error");
                    }
                    else
                    {
                        errorlogin.Icon = Properties.Resources.ok;
                        errorlogin.SetError(tb1, "ok");
                    }
                }

                private void tb2_Leave(object sender, EventArgs e)
                {
                    if (string.IsNullOrEmpty(tb2.Text))
                    {
                        errorpass.Icon = Properties.Resources.err;
                        errorpass.SetError(tb2, "Password error");
                    }
                    else
                    {
                        errorpass.Icon = Properties.Resources.ok;
                        errorpass.SetError(tb2, "ok");
                    }

                }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        //private void cbox_Leave(object sender, EventArgs e)
        //{
        //    if (cbox.SelectedIndex > -1)
        //    {
        //        errorpass.Icon = Properties.Resources.err;
        //        errorpass.SetError(cbox, "Password error");
        //    }
        //    else
        //    {
        //        errorpass.Icon = Properties.Resources.ok;
        //        errorpass.SetError(cbox, "ok");
        //    }

        //}

    }
}






