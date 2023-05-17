
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
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startBtn.Location = new System.Drawing.Point(550, 800);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(160, 75);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitBtn.Location = new System.Drawing.Point(1156, 800);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(160, 75);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuBtn.Location = new System.Drawing.Point(754, 800);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(160, 75);
            this.menuBtn.TabIndex = 2;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // descriptionBtn
            // 
            this.descriptionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descriptionBtn.Location = new System.Drawing.Point(950, 800);
            this.descriptionBtn.Name = "descriptionBtn";
            this.descriptionBtn.Size = new System.Drawing.Size(160, 75);
            this.descriptionBtn.TabIndex = 3;
            this.descriptionBtn.Text = "Description";
            this.descriptionBtn.UseVisualStyleBackColor = true;
            this.descriptionBtn.Click += new System.EventHandler(this.descriptionBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::OldBroGame.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1378, 944);
            this.Controls.Add(this.descriptionBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Title Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button descriptionBtn;
    }
}