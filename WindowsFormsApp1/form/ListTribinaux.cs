using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.form
{
    public partial class ListTribinaux : Form
    {

        public ListTribinaux()
        {
            InitializeComponent();
        }

        private void pdfViewer1_Load(object sender, EventArgs e)
        {

        }
        public Form RefToHome
        { get; set; }
        private void ListTribinaux_Load(object sender, EventArgs e)
        {

        }

        private void ListTribinaux_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToHome.Show();

        }
    }
}
