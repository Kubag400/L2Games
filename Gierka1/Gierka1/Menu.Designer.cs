
namespace Gierka1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.playBtn = new System.Windows.Forms.PictureBox();
            this.scoreBtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Image = global::Gierka1.Properties.Resources.play_button;
            resources.ApplyResources(this.playBtn, "playBtn");
            this.playBtn.Name = "playBtn";
            this.playBtn.TabStop = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // scoreBtn
            // 
            this.scoreBtn.Image = global::Gierka1.Properties.Resources.score;
            resources.ApplyResources(this.scoreBtn, "scoreBtn");
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.TabStop = false;
            this.scoreBtn.Click += new System.EventHandler(this.scoreBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::Gierka1.Properties.Resources.logout;
            resources.ApplyResources(this.exitBtn, "exitBtn");
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.scoreBtn);
            this.Controls.Add(this.playBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playBtn;
        private System.Windows.Forms.PictureBox scoreBtn;
        private System.Windows.Forms.PictureBox exitBtn;
    }
}

