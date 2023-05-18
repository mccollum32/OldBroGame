
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
            this.startBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.descriptionBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startBtn.Location = new System.Drawing.Point(450, 5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(150, 50);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitBtn.Location = new System.Drawing.Point(1200, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(150, 50);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuBtn.Location = new System.Drawing.Point(100, 5);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(150, 50);
            this.menuBtn.TabIndex = 2;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // descriptionBtn
            // 
            this.descriptionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descriptionBtn.Location = new System.Drawing.Point(825, 5);
            this.descriptionBtn.Name = "descriptionBtn";
            this.descriptionBtn.Size = new System.Drawing.Size(150, 50);
            this.descriptionBtn.TabIndex = 3;
            this.descriptionBtn.Text = "Description";
            this.descriptionBtn.UseVisualStyleBackColor = true;
            this.descriptionBtn.Click += new System.EventHandler(this.descriptionBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.descriptionBtn);
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 985);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 59);
            this.panel1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::OldBroGame.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 1044);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title Page";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button descriptionBtn;
        private System.Windows.Forms.Panel panel1;
    }
}