using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObadaElla_Event_Management
{
    public partial class EventHome : Form
    {
        public EventHome()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void event_add_Click(object sender, EventArgs e)
        {
            Form_Add obj = new Form_Add();
            obj.Show();
            this.Hide();
        }

        private void event_view_Click(object sender, EventArgs e)
        {

        }

        private void event_specialnotice_Click(object sender, EventArgs e)
        {

        }
    }
}
