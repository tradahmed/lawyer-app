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
using WindowsFormsApp1.Forms;

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
                cmd = new SqlCommand("select count (*) from Auth where login=@login and pass=@pass", cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@login", tb1.Text);
                cmd.Parameters.AddWithValue("@pass", tb2.Text);
                cn.Open();

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    errorlogin.Icon = Properties.Resources.ok;
                    errorlogin.SetError(tb1, "ok");
                    errorpass.Icon = Properties.Resources.ok;
                    errorpass.SetError(tb2, "ok");

                    MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                    this.Hide();
                    var sh = new home();
                    sh.Closed += (s, args) => this.Close();
                    sh.Show();
                }

                else
                {
                    errorlogin.Icon = Properties.Resources.err;
                    errorlogin.SetError(tb1, "Login error");
                    errorpass.Icon = Properties.Resources.err;
                    errorpass.SetError(tb2, "Password error");
                    MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS \n CHECK YOUR LOGIN OR PASSWORD ");
                    lbl_Msg.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
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





