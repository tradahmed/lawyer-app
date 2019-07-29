using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.form
{
    public partial class rapportadmincs : Form
    {
        public rapportadmincs()
        {
            InitializeComponent();
        }

        private void rapportadmincs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avocatsDataSetRapport.rapport' table. You can move, or remove it, as needed.
            this.rapportTableAdapter.Fill(this.avocatsDataSetRapport.rapport);

        }
    }
}
