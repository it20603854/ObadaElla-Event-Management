using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObadaElla_Event_Management
{
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void event_addnew_Click(object sender, EventArgs e)
        {
            FormAddNewEvent obj = new FormAddNewEvent();
            obj.Show();
            this.Hide();
        }

        private void event_addspecial_Click(object sender, EventArgs e)
        {
            FormSpecialNotices obj = new FormSpecialNotices();
            obj.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            EventHome obj = new EventHome();
            obj.Show();
            this.Hide();
        }
    }
}
