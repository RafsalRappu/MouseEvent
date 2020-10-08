using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            txtName.Text = "Enter your name";
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnSave_MouseDown(object sender, MouseEventArgs e)
        {
            btnSave.BackColor = Color.Red;
        }

        private void btnSave_MouseUp(object sender, MouseEventArgs e)
        {
            btnSave.BackColor = Color.Green;
        }
    }
}
