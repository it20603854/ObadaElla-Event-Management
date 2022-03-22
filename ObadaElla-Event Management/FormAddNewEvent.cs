using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObadaElla_Event_Management
{
    public partial class FormAddNewEvent : Form
    {
        public FormAddNewEvent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void event_back_Click(object sender, EventArgs e)
        {
            Form_Add obj = new Form_Add();
            obj.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
