namespace TempoGame1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RedTaikoMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RedTaikoMoveTimer2 = new System.Windows.Forms.Timer(this.components);
            this.RedBPicture = new System.Windows.Forms.PictureBox();
            this.TaikoProPicture = new System.Windows.Forms.PictureBox();
            this.GameExitButton = new System.Windows.Forms.PictureBox();
            this.GameInstructionButton = new System.Windows.Forms.PictureBox();
            this.GameStartButton = new System.Windows.Forms.PictureBox();
            this.HomeBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedBPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaikoProPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameInstructionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameStartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBG)).BeginInit();
            this.SuspendLayout();
            // 
            // RedTaikoMoveTimer
            // 
            this.RedTaikoMoveTimer.Tick += new System.EventHandler(this.RedTaikoMoveTimer_Tick);
            // 
            // RedTaikoMoveTimer2
            // 
            this.RedTaikoMoveTimer2.Tick += new System.EventHandler(this.RedTaikoMoveTimer2_Tick);
            // 
            // RedBPicture
            // 
            this.RedBPicture.Image = global::TempoGame1.Properties.Resources.RedBrother2;
            this.RedBPicture.Location = new System.Drawing.Point(586, 423);
            this.RedBPicture.Name = "RedBPicture";
            this.RedBPicture.Size = new System.Drawing.Size(173, 126);
            this.RedBPicture.TabIndex = 8;
            this.RedBPicture.TabStop = false;
            // 
            // TaikoProPicture
            // 
            this.TaikoProPicture.Image = global::TempoGame1.Properties.Resources.TaikoPro;
            this.TaikoProPicture.Location = new System.Drawing.Point(12, 11);
            this.TaikoProPicture.Name = "TaikoProPicture";
            this.TaikoProPicture.Size = new System.Drawing.Size(284, 180);
            this.TaikoProPicture.TabIndex = 7;
            this.TaikoProPicture.TabStop = false;
            // 
            // GameExitButton
            // 
            this.GameExitButton.Image = global::TempoGame1.Properties.Resources.Exit;
            this.GameExitButton.Location = new System.Drawing.Point(217, 371);
            this.GameExitButton.Name = "GameExitButton";
            this.GameExitButton.Size = new System.Drawing.Size(350, 100);
            this.GameExitButton.TabIndex = 6;
            this.GameExitButton.TabStop = false;
            this.GameExitButton.Click += new System.EventHandler(this.GameExitButton_Click);
            // 
            // GameInstructionButton
            // 
            this.GameInstructionButton.Image = global::TempoGame1.Properties.Resources.Game_Instruction;
            this.GameInstructionButton.Location = new System.Drawing.Point(217, 252);
            this.GameInstructionButton.Name = "GameInstructionButton";
            this.GameInstructionButton.Size = new System.Drawing.Size(350, 100);
            this.GameInstructionButton.TabIndex = 5;
            this.GameInstructionButton.TabStop = false;
            this.GameInstructionButton.Click += new System.EventHandler(this.GameInstructionButton_Click);
            // 
            // GameStartButton
            // 
            this.GameStartButton.Image = global::TempoGame1.Properties.Resources.GameStart;
            this.GameStartButton.Location = new System.Drawing.Point(202, 119);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(350, 100);
            this.GameStartButton.TabIndex = 4;
            this.GameStartButton.TabStop = false;
            this.GameStartButton.Click += new System.EventHandler(this.GameStartButton_Click);
            // 
            // HomeBG
            // 
            this.HomeBG.Image = global::TempoGame1.Properties.Resources.bg3;
            this.HomeBG.Location = new System.Drawing.Point(0, 0);
            this.HomeBG.Name = "HomeBG";
            this.HomeBG.Size = new System.Drawing.Size(785, 561);
            this.HomeBG.TabIndex = 2;
            this.HomeBG.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.RedBPicture);
            this.Controls.Add(this.TaikoProPicture);
            this.Controls.Add(this.GameExitButton);
            this.Controls.Add(this.GameInstructionButton);
            this.Controls.Add(this.GameStartButton);
            this.Controls.Add(this.HomeBG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taiko";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedBPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaikoProPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameInstructionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameStartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HomeBG;
        private System.Windows.Forms.PictureBox GameStartButton;
        private System.Windows.Forms.PictureBox GameInstructionButton;
        private System.Windows.Forms.PictureBox GameExitButton;
        private System.Windows.Forms.PictureBox TaikoProPicture;
        private System.Windows.Forms.PictureBox RedBPicture;
        private System.Windows.Forms.Timer RedTaikoMoveTimer;
        private System.Windows.Forms.Timer RedTaikoMoveTimer2;
    }
}

