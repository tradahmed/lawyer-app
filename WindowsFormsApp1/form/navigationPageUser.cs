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
using WindowsFormsApp1.form;

namespace WindowsFormsApp1
{
    public partial class Home1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=Avocats;Integrated Security=True");
        SqlCommand cmd;

        public Home1(string Username)
        {
            InitializeComponent();
            label1.Text = Username; 
            SlidePanel.Height = bt1.Height;

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = bt1.Height;
            SlidePanel.Top = bt1.Top;
            Agenda ag = new form.Agenda();
            ag.RefToHome = this;
            this.Visible=false;
            ag.Show();
            

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = bt2.Height;
            SlidePanel.Top = bt2.Top;
            var rp = new rapport();
            rp.RefToHome = this;
            this.Visible = false;
            this.Hide();

            rp.Show();

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = bt3.Height;
            SlidePanel.Top = bt3.Top;
            var ms = new Mession();
            ms.RefToHome = this;
            this.Visible = false;
            this.Hide();

            ms.Show();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = bt4.Height;
            SlidePanel.Top = bt4.Top;
            var la = new ListAvocat();
            this.Hide();
            la.RefToHome = this;
            this.Visible = false;
            la.Show();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = bt5.Height;
            SlidePanel.Top = bt5.Top;
            var lh = new ListHuissier();
            this.Hide();
            lh.RefToHome = this;
            this.Visible = false;
            lh.Show();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = bt6.Height;
            SlidePanel.Top = bt6.Top;
            var lt = new ListTribinaux();
            lt.RefToHome = this;
            this.Visible = false;
            this.Hide();

            lt.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var wlc = new Welcome();
            wlc.Closed += (s, args) => this.Close();
            wlc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var UI = new userInterface();
            UI.Show();
            this.Hide();
            UI.RefToHome = this;
            this.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("هل تريد المغادرة؟",
                               "مذكرة المحامي",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
