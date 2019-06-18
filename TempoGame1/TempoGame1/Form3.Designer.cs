namespace TempoGame1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.HomeButton = new System.Windows.Forms.Button();
            this.HomeButtonIns = new System.Windows.Forms.PictureBox();
            this.HomeBG3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButtonIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBG3)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(326, 225);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(122, 58);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // HomeButtonIns
            // 
            this.HomeButtonIns.Image = global::TempoGame1.Properties.Resources.Home;
            this.HomeButtonIns.Location = new System.Drawing.Point(193, 36);
            this.HomeButtonIns.Name = "HomeButtonIns";
            this.HomeButtonIns.Size = new System.Drawing.Size(350, 100);
            this.HomeButtonIns.TabIndex = 4;
            this.HomeButtonIns.TabStop = false;
            this.HomeButtonIns.Click += new System.EventHandler(this.HomeButtonIns_Click);
            // 
            // HomeBG3
            // 
            this.HomeBG3.Image = global::TempoGame1.Properties.Resources.bg_Ins3;
            this.HomeBG3.Location = new System.Drawing.Point(0, 0);
            this.HomeBG3.Name = "HomeBG3";
            this.HomeBG3.Size = new System.Drawing.Size(785, 561);
            this.HomeBG3.TabIndex = 3;
            this.HomeBG3.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.HomeButtonIns);
            this.Controls.Add(this.HomeBG3);
            this.Controls.Add(this.HomeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taiko Instruction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeButtonIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBG3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.PictureBox HomeBG3;
        private System.Windows.Forms.PictureBox HomeButtonIns;

    }
}