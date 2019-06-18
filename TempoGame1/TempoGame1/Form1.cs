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
    public partial class Form1 : Form
    {
        int downposition = 423;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void B_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void C_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.GameStartButton.BackColor = Color.Transparent;
            this.GameStartButton.Parent = this.HomeBG;
            this.GameInstructionButton.BackColor = Color.Transparent;
            this.GameInstructionButton.Parent = this.HomeBG;
            this.GameExitButton.BackColor = Color.Transparent;
            this.GameExitButton.Parent = this.HomeBG;
            this.TaikoProPicture.BackColor = Color.Transparent;
            this.TaikoProPicture.Parent = this.HomeBG;
            this.RedBPicture.BackColor = Color.Transparent;
            this.RedBPicture.Parent = this.HomeBG;
            RedTaikoMoveTimer.Start();
        }

        private void GameStartButton_Click(object sender, EventArgs e)
        {
            Form2 bForm = new Form2();
            bForm.FormClosed += new FormClosedEventHandler(B_FormClosed);
            bForm.Show();
            this.Hide();
        }

        private void GameInstructionButton_Click(object sender, EventArgs e)
        {
            Form3 cForm = new Form3();
            cForm.FormClosed += new FormClosedEventHandler(C_FormClosed);
            cForm.Show();
            this.Hide(); 
        }

        private void GameExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RedTaikoMoveTimer_Tick(object sender, EventArgs e)
        {
            if (downposition > 345)
            {
                if (downposition <= 423)
                {
                    downposition -= 10;
                    RedBPicture.Top -= 10;

                }
                
            }

            else if (downposition <= 345)
            {
                RedTaikoMoveTimer.Stop();
                RedTaikoMoveTimer2.Start();
                
            }

        }

        private void RedTaikoMoveTimer2_Tick(object sender, EventArgs e)
        {
                downposition += 10;
                RedBPicture.Top += 10;
            
            if (downposition >= 423)
            {
                RedTaikoMoveTimer2.Stop();
                RedTaikoMoveTimer.Start();
            }

        }
    }
}
