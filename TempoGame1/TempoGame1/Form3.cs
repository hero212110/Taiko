using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempoGame1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void A_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Form1 aForm = new Form1();
            aForm.FormClosed += new FormClosedEventHandler(A_FormClosed);
            aForm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.HomeButtonIns.BackColor = Color.Transparent;
            this.HomeButtonIns.Parent = this.HomeBG3;
        }

        private void HomeButtonIns_Click(object sender, EventArgs e)
        {
            Form1 aForm = new Form1();
            aForm.FormClosed += new FormClosedEventHandler(A_FormClosed);
            aForm.Show();
            this.Hide();
        }



    }
}
