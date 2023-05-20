
namespace OldBroGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.startButton1 = new System.Windows.Forms.RadioButton();
            this.aboutButton2 = new System.Windows.Forms.RadioButton();
            this.quitButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1478, 1044);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoLabel.Font = new System.Drawing.Font("Showcard Gothic", 100F);
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(0, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(1478, 1044);
            this.logoLabel.TabIndex = 7;
            this.logoLabel.Text = "Old Bro";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton1
            // 
            this.startButton1.AutoSize = true;
            this.startButton1.BackColor = System.Drawing.Color.Black;
            this.startButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.startButton1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.startButton1.Location = new System.Drawing.Point(650, 901);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(169, 34);
            this.startButton1.TabIndex = 11;
            this.startButton1.Text = "Start Game";
            this.startButton1.UseVisualStyleBackColor = false;
            this.startButton1.CheckedChanged += new System.EventHandler(this.startButton1_CheckedChanged);
            // 
            // aboutButton2
            // 
            this.aboutButton2.AutoSize = true;
            this.aboutButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aboutButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutButton2.ForeColor = System.Drawing.Color.White;
            this.aboutButton2.Location = new System.Drawing.Point(350, 901);
            this.aboutButton2.Name = "aboutButton2";
            this.aboutButton2.Size = new System.Drawing.Size(181, 34);
            this.aboutButton2.TabIndex = 12;
            this.aboutButton2.Text = "About Game";
            this.aboutButton2.UseVisualStyleBackColor = false;
            this.aboutButton2.CheckedChanged += new System.EventHandler(this.aboutButton2_CheckedChanged);
            // 
            // quitButton3
            // 
            this.quitButton3.AutoSize = true;
            this.quitButton3.BackColor = System.Drawing.Color.Black;
            this.quitButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.quitButton3.ForeColor = System.Drawing.Color.Red;
            this.quitButton3.Location = new System.Drawing.Point(951, 901);
            this.quitButton3.Name = "quitButton3";
            this.quitButton3.Size = new System.Drawing.Size(162, 34);
            this.quitButton3.TabIndex = 13;
            this.quitButton3.Text = "Quit Game";
            this.quitButton3.UseVisualStyleBackColor = false;
            this.quitButton3.CheckedChanged += new System.EventHandler(this.quitButton3_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 1044);
            this.Controls.Add(this.quitButton3);
            this.Controls.Add(this.aboutButton2);
            this.Controls.Add(this.startButton1);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.RadioButton startButton1;
        private System.Windows.Forms.RadioButton aboutButton2;
        private System.Windows.Forms.RadioButton quitButton3;
    }
}