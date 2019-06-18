namespace TempoGame1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Taikotimer = new System.Windows.Forms.Timer(this.components);
            this.HitSecondsTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.TaikoCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.PlayUsingTimeLabel = new System.Windows.Forms.Label();
            this.CircleHitTimer = new System.Windows.Forms.Timer(this.components);
            this.CircleHitTimer2 = new System.Windows.Forms.Timer(this.components);
            this.redcircle = new System.Windows.Forms.PictureBox();
            this.bluecircle = new System.Windows.Forms.PictureBox();
            this.owari = new System.Windows.Forms.PictureBox();
            this.HitTaiko = new System.Windows.Forms.PictureBox();
            this.Taiko4 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.StopBtn = new System.Windows.Forms.PictureBox();
            this.PlayBtn = new System.Windows.Forms.PictureBox();
            this.Taiko3 = new System.Windows.Forms.PictureBox();
            this.Taiko2 = new System.Windows.Forms.PictureBox();
            this.Taiko1 = new System.Windows.Forms.PictureBox();
            this.BGPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redcircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluecircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.owari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitTaiko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taiko4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taiko3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taiko2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taiko1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Taikotimer
            // 
            this.Taikotimer.Tick += new System.EventHandler(this.Taikotimer_Tick);
            // 
            // HitSecondsTimer
            // 
            this.HitSecondsTimer.Tick += new System.EventHandler(this.HitSecondsTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.White;
            this.scoreLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scoreLabel.Location = new System.Drawing.Point(575, 116);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(34, 37);
            this.scoreLabel.TabIndex = 15;
            this.scoreLabel.Text = "0";
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Tick += new System.EventHandler(this.ScoreTimer_Tick);
            // 
            // TaikoCountLabel
            // 
            this.TaikoCountLabel.AutoSize = true;
            this.TaikoCountLabel.BackColor = System.Drawing.Color.White;
            this.TaikoCountLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TaikoCountLabel.Location = new System.Drawing.Point(721, 116);
            this.TaikoCountLabel.Name = "TaikoCountLabel";
            this.TaikoCountLabel.Size = new System.Drawing.Size(34, 37);
            this.TaikoCountLabel.TabIndex = 17;
            this.TaikoCountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(503, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(624, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total:";
            // 
            // EndTimer
            // 
            this.EndTimer.Tick += new System.EventHandler(this.EndTimer_Tick);
            // 
            // PlayTimer
            // 
            this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(181, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time:";
            // 
            // PlayUsingTimeLabel
            // 
            this.PlayUsingTimeLabel.AutoSize = true;
            this.PlayUsingTimeLabel.BackColor = System.Drawing.Color.White;
            this.PlayUsingTimeLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayUsingTimeLabel.Location = new System.Drawing.Point(181, 86);
            this.PlayUsingTimeLabel.Name = "PlayUsingTimeLabel";
            this.PlayUsingTimeLabel.Size = new System.Drawing.Size(34, 37);
            this.PlayUsingTimeLabel.TabIndex = 22;
            this.PlayUsingTimeLabel.Text = "0";
            // 
            // CircleHitTimer
            // 
            this.CircleHitTimer.Tick += new System.EventHandler(this.CircleHitTimer_Tick);
            // 
            // CircleHitTimer2
            // 
            this.CircleHitTimer2.Tick += new System.EventHandler(this.CircleHitTimer2_Tick);
            // 
            // redcircle
            // 
            this.redcircle.BackColor = System.Drawing.Color.Black;
            this.redcircle.Image = global::TempoGame1.Properties.Resources.redcircle;
            this.redcircle.Location = new System.Drawing.Point(62, 195);
            this.redcircle.Name = "redcircle";
            this.redcircle.Size = new System.Drawing.Size(74, 127);
            this.redcircle.TabIndex = 24;
            this.redcircle.TabStop = false;
            // 
            // bluecircle
            // 
            this.bluecircle.BackColor = System.Drawing.Color.Black;
            this.bluecircle.Image = global::TempoGame1.Properties.Resources.bluecircle;
            this.bluecircle.Location = new System.Drawing.Point(60, 195);
            this.bluecircle.Name = "bluecircle";
            this.bluecircle.Size = new System.Drawing.Size(74, 127);
            this.bluecircle.TabIndex = 23;
            this.bluecircle.TabStop = false;
            // 
            // owari
            // 
            this.owari.Image = global::TempoGame1.Properties.Resources.timeisup;
            this.owari.Location = new System.Drawing.Point(140, 156);
            this.owari.Name = "owari";
            this.owari.Size = new System.Drawing.Size(561, 321);
            this.owari.TabIndex = 20;
            this.owari.TabStop = false;
            // 
            // HitTaiko
            // 
            this.HitTaiko.BackColor = System.Drawing.Color.Black;
            this.HitTaiko.Image = global::TempoGame1.Properties.Resources.Hit3;
            this.HitTaiko.Location = new System.Drawing.Point(146, 189);
            this.HitTaiko.Name = "HitTaiko";
            this.HitTaiko.Size = new System.Drawing.Size(120, 120);
            this.HitTaiko.TabIndex = 9;
            this.HitTaiko.TabStop = false;
            this.HitTaiko.Visible = false;
            // 
            // Taiko4
            // 
            this.Taiko4.BackColor = System.Drawing.Color.Black;
            this.Taiko4.Image = global::TempoGame1.Properties.Resources.red;
            this.Taiko4.Location = new System.Drawing.Point(700, 210);
            this.Taiko4.Name = "Taiko4";
            this.Taiko4.Size = new System.Drawing.Size(70, 70);
            this.Taiko4.TabIndex = 16;
            this.Taiko4.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.White;
            this.ExitBtn.Image = global::TempoGame1.Properties.Resources.ExitButton1;
            this.ExitBtn.Location = new System.Drawing.Point(672, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 40);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Image = global::TempoGame1.Properties.Resources.BackButton1;
            this.BackBtn.Location = new System.Drawing.Point(548, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 40);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.White;
            this.StopBtn.Image = global::TempoGame1.Properties.Resources.StopButton1;
            this.StopBtn.Location = new System.Drawing.Point(672, 58);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(100, 40);
            this.StopBtn.TabIndex = 11;
            this.StopBtn.TabStop = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.White;
            this.PlayBtn.Image = global::TempoGame1.Properties.Resources.PlayButton1;
            this.PlayBtn.Location = new System.Drawing.Point(548, 58);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(100, 40);
            this.PlayBtn.TabIndex = 10;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // Taiko3
            // 
            this.Taiko3.BackColor = System.Drawing.Color.Black;
            this.Taiko3.Image = global::TempoGame1.Properties.Resources.blue;
            this.Taiko3.Location = new System.Drawing.Point(700, 210);
            this.Taiko3.Name = "Taiko3";
            this.Taiko3.Size = new System.Drawing.Size(70, 70);
            this.Taiko3.TabIndex = 8;
            this.Taiko3.TabStop = false;
            // 
            // Taiko2
            // 
            this.Taiko2.BackColor = System.Drawing.Color.Black;
            this.Taiko2.Image = global::TempoGame1.Properties.Resources.blue;
            this.Taiko2.Location = new System.Drawing.Point(700, 210);
            this.Taiko2.Name = "Taiko2";
            this.Taiko2.Size = new System.Drawing.Size(70, 70);
            this.Taiko2.TabIndex = 7;
            this.Taiko2.TabStop = false;
            // 
            // Taiko1
            // 
            this.Taiko1.BackColor = System.Drawing.Color.Black;
            this.Taiko1.Image = global::TempoGame1.Properties.Resources.red;
            this.Taiko1.Location = new System.Drawing.Point(700, 210);
            this.Taiko1.Name = "Taiko1";
            this.Taiko1.Size = new System.Drawing.Size(70, 70);
            this.Taiko1.TabIndex = 5;
            this.Taiko1.TabStop = false;
            // 
            // BGPicture
            // 
            this.BGPicture.Image = global::TempoGame1.Properties.Resources.bg2;
            this.BGPicture.Location = new System.Drawing.Point(0, 0);
            this.BGPicture.Name = "BGPicture";
            this.BGPicture.Size = new System.Drawing.Size(785, 561);
            this.BGPicture.TabIndex = 14;
            this.BGPicture.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.redcircle);
            this.Controls.Add(this.bluecircle);
            this.Controls.Add(this.PlayUsingTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.owari);
            this.Controls.Add(this.HitTaiko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaikoCountLabel);
            this.Controls.Add(this.Taiko4);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.Taiko3);
            this.Controls.Add(this.Taiko2);
            this.Controls.Add(this.Taiko1);
            this.Controls.Add(this.BGPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taiko Playing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.redcircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluecircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.owari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitTaiko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taiko4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taiko3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taiko2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taiko1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Taiko1;
        private System.Windows.Forms.Timer Taikotimer;
        private System.Windows.Forms.PictureBox Taiko2;
        private System.Windows.Forms.PictureBox Taiko3;
        private System.Windows.Forms.PictureBox HitTaiko;
        private System.Windows.Forms.Timer HitSecondsTimer;
        private System.Windows.Forms.PictureBox PlayBtn;
        private System.Windows.Forms.PictureBox StopBtn;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox BGPicture;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer ScoreTimer;
        private System.Windows.Forms.PictureBox Taiko4;
        private System.Windows.Forms.Label TaikoCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer EndTimer;
        private System.Windows.Forms.PictureBox owari;
        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PlayUsingTimeLabel;
        private System.Windows.Forms.PictureBox bluecircle;
        private System.Windows.Forms.PictureBox redcircle;
        private System.Windows.Forms.Timer CircleHitTimer;
        private System.Windows.Forms.Timer CircleHitTimer2;
    }
}