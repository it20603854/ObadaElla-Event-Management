using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObadaElla_Event_Management
{
    public partial class FormEventView : Form
    {
        public FormEventView()
        {
            InitializeComponent();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            EventHome obj = new EventHome();
            obj.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
