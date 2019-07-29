using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraScheduler;

namespace WindowsFormsApp1.form
{
    public partial class Agenda : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Agenda()
        {
            InitializeComponent();
        }
        public Form RefToHome
        { get; set; }
        private void Agenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulerTest.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.schedulerTest.Resources);
            // TODO: This line of code loads data into the 'schedulerTest.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.schedulerTest.Appointments);
        }

        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(schedulerTest);
            schedulerTest.AcceptChanges();
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(schedulerTest);
            schedulerTest.AcceptChanges();
        }

        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(schedulerTest);
            schedulerTest.AcceptChanges();
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            WindowsFormsApp1.form.OutlookAppointmentForm form = new WindowsFormsApp1.form.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }



        private void Agenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToHome.Show();

        }
    }
}