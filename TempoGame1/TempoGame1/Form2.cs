using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;

namespace TempoGame1
{
    public partial class Form2 : Form
    {
        
        int a = 700;
        int b = 700;
        int c = 700;
        int d = 700;
        int a2 = 700;
        int b2 = 700;
        int c2 = 700;
        int d2 = 700;
        int taikocount = 0;
        int myscore = 0;
        float hs = 0f;
        float ch = 0f;
        float ch2 = 0f;
        int endtime;
        int playtime = 0;

        public Form2()
        {
            InitializeComponent();                       
        }


        private void Taikotimer_Tick(object sender, EventArgs e)
        {
            a -= 25;
            a2 -= 25;
            Taiko1.Left -= 25;
            if (a2 < 155)
            {
                taikocount += 1;
                Taiko1.Left = 700;
                Taiko1.Left -= 25;
                a2 = 700;
                
                Taiko1.Visible = true;
                
            }
            if (a < 580)
            {
                
                Taiko2.Visible = true;
                b -= 25;
                b2 -= 25;
                Taiko2.Left -= 25;
                if (b2 < 155)
                {
                    taikocount += 1;
                    Taiko2.Left = 700;
                    Taiko2.Left -= 25;
                    b2 = 700;
                    Taiko2.Visible = true;
                }
            }
            if (b < 600)
            {
                Taiko3.Visible = true;
                c -= 25;
                c2 -= 25;
                
                Taiko3.Left -= 25;
                if (c2 < 155)
                {
                    taikocount += 1;
                    Taiko3.Left = 700;
                    Taiko3.Left -= 25;
                    c2 = 700;
                    Taiko3.Visible = true;
                }
            }

            if (b < 500)
            {
                Taiko4.Visible = true;
                d -= 25;
                d2 -= 25;

                Taiko4.Left -= 25;
                if (d2 < 155)
                {
                    taikocount += 1;
                    Taiko4.Left = 700;
                    Taiko4.Left -= 25;
                    d2 = 700;
                    Taiko4.Visible = true;
                }
            }
                       
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bluecircle.Visible = false;
            redcircle.Visible = false;
            this.bluecircle.BackColor = Color.Transparent;
            this.bluecircle.Parent = this.BGPicture;
            this.redcircle.BackColor = Color.Transparent;
            this.redcircle.Parent = this.BGPicture;
            this.Taiko1.BackColor = Color.Transparent;
            this.Taiko1.Parent = this.BGPicture;
            this.Taiko2.BackColor = Color.Transparent;
            this.Taiko2.Parent = this.BGPicture;
            this.Taiko3.BackColor = Color.Transparent;
            this.Taiko3.Parent = this.BGPicture;
            this.Taiko4.BackColor = Color.Transparent;
            this.Taiko4.Parent = this.BGPicture;
            this.owari.BackColor = Color.Transparent;
            this.owari.Parent = this.BGPicture;
            //this.HitTaiko.BackColor = Color.Transparent;
            //this.HitTaiko.Parent = this.BGPicture;
            Taiko1.Visible = false;
            Taiko2.Visible = false;
            Taiko3.Visible = false;
            Taiko4.Visible = false;
            HitTaiko.Visible = false;
            owari.Visible = false;
            label3.Visible = false;
            PlayUsingTimeLabel.Visible = false;
            

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    {
                        redcircle.Visible = true;
                        CircleHitTimer.Start();
                        if (a2 > 144)
                        {
                            if (a2 < 213)
                            {
                                
                                HitTaiko.Visible = true;
                                myscore += 1;
                                Taiko1.Visible = false;
                               
                            }

                            else if (d2 > 144)
                            {
                                if (d2 < 213)
                                {
                                    Taiko4.Visible = false;
                                    HitTaiko.Visible = true;
                                    myscore += 1;
 
                                }
                                
                            }

                        }
             
                        HitSecondsTimer.Start();                       
                      
                        break;
                    }

                case Keys.V:
                    {
                        bluecircle.Visible = true;
                        CircleHitTimer2.Start();
                        if (b2 > 144)
                        {
                            if (b2 < 213)
                            {

                                HitTaiko.Visible = true;
                                myscore += 1;
                                Taiko2.Visible = false;

                            }

                            else if (c2 > 144)
                            {
                                if (c2 < 213)
                                {
                                    Taiko3.Visible = false;
                                    HitTaiko.Visible = true;
                                    myscore += 1;

                                }

                            }

                        }

                        HitSecondsTimer.Start();

                        break;
                    }
            }
        }

        private void HitSecondsTimer_Tick(object sender, EventArgs e)
        {
            HitSecondsTimer.Interval = 200;

            hs+=0.2f;

            if (hs > 0.2)
            {
                hs = 0;
                HitSecondsTimer.Stop();
                HitTaiko.Visible = false;
                
            }
        }

        private void A_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 aForm = new Form1();
            aForm.FormClosed += new FormClosedEventHandler(A_FormClosed);
            aForm.Show();
            this.Hide();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = @"C:\Users\acer\Desktop\Things\Music\wav\My Dearest.wav";
            player.Stop();
            player.Dispose();
            Taikotimer.Stop();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();           
            player.Stream = Properties.Resources.Believer3;
            //player.SoundLocation = @"C:\Users\acer\Desktop\Things\Music\wav\My Dearest.wav";
            
            player.Play();
            Taiko1.Visible = true;
            Taikotimer.Start();
            ScoreTimer.Start();
            PlayTimer.Start();
            taikocount = 0;
            myscore = 0;
            owari.Visible = false;

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = @"C:\Users\acer\Desktop\Things\Music\wav\My Dearest.wav";
            player.Stop();
            player.Dispose();
            Taikotimer.Stop();
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ScoreTimer_Tick(object sender, EventArgs e)
        {

            scoreLabel.Text = myscore.ToString();
            TaikoCountLabel.Text = taikocount.ToString();

            if (taikocount == 100)
            {
                Taikotimer.Stop();
                HitSecondsTimer.Stop();
                ScoreTimer.Stop();

                /*System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                //player.SoundLocation = @"C:\Users\acer\Desktop\Things\Music\wav\My Dearest.wav";
                player.Stop();
                player.Dispose();*/


                Taiko1.Visible = false;
                Taiko2.Visible = false;
                Taiko3.Visible = false;
                Taiko4.Visible = false;
                HitTaiko.Visible = false;
                owari.Visible = true;
                endtime = 0;
                PlayTimer.Stop();
            }

        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EndTimer_Tick(object sender, EventArgs e)
        {
            endtime++;
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            PlayTimer.Interval = 1000;

            playtime++;

            PlayUsingTimeLabel.Text = playtime.ToString();
        }

        private void CircleHitTimer_Tick(object sender, EventArgs e)
        {
            CircleHitTimer.Interval = 200;

            ch += 0.2f;

            if (ch > 0.2)
            {
                ch = 0;
                CircleHitTimer.Stop();
                redcircle.Visible = false;

            }
        }

        private void CircleHitTimer2_Tick(object sender, EventArgs e)
        {
            CircleHitTimer2.Interval = 200;

            ch2 += 0.2f;

            if (ch2 > 0.2)
            {
                ch2 = 0;
                CircleHitTimer2.Stop();
                bluecircle.Visible = false;
            }

        }











    }
}
