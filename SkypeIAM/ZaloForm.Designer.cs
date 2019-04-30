namespace ZaloSpammer
{
    partial class ZaloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaloForm));
            this.pnMenuRight = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKetbanMenu = new System.Windows.Forms.Button();
            this.btnSpamMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnMenuRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuRight
            // 
            this.pnMenuRight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnMenuRight.Controls.Add(this.pictureBox1);
            this.pnMenuRight.Controls.Add(this.btnKetbanMenu);
            this.pnMenuRight.Controls.Add(this.btnSpamMenu);
            this.pnMenuRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuRight.Location = new System.Drawing.Point(0, 0);
            this.pnMenuRight.Name = "pnMenuRight";
            this.pnMenuRight.Size = new System.Drawing.Size(255, 609);
            this.pnMenuRight.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnKetbanMenu
            // 
            this.btnKetbanMenu.FlatAppearance.BorderSize = 0;
            this.btnKetbanMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKetbanMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetbanMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetbanMenu.ForeColor = System.Drawing.Color.White;
            this.btnKetbanMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnKetbanMenu.Image")));
            this.btnKetbanMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKetbanMenu.Location = new System.Drawing.Point(0, 154);
            this.btnKetbanMenu.Name = "btnKetbanMenu";
            this.btnKetbanMenu.Size = new System.Drawing.Size(254, 58);
            this.btnKetbanMenu.TabIndex = 0;
            this.btnKetbanMenu.Text = "Kết bạn";
            this.btnKetbanMenu.UseVisualStyleBackColor = true;
            this.btnKetbanMenu.Click += new System.EventHandler(this.BtnKetbanMenu_Click);
            // 
            // btnSpamMenu
            // 
            this.btnSpamMenu.FlatAppearance.BorderSize = 0;
            this.btnSpamMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSpamMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpamMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpamMenu.ForeColor = System.Drawing.Color.White;
            this.btnSpamMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSpamMenu.Image")));
            this.btnSpamMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpamMenu.Location = new System.Drawing.Point(0, 89);
            this.btnSpamMenu.Name = "btnSpamMenu";
            this.btnSpamMenu.Size = new System.Drawing.Size(254, 58);
            this.btnSpamMenu.TabIndex = 0;
            this.btnSpamMenu.Text = "Spam";
            this.btnSpamMenu.UseVisualStyleBackColor = true;
            this.btnSpamMenu.Click += new System.EventHandler(this.BtnSpamMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(255, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 67);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(692, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(255, 67);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(736, 542);
            this.pnContent.TabIndex = 2;
            // 
            // ZaloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(991, 609);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnMenuRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZaloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZaloForm";
            this.pnMenuRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuRight;
        private System.Windows.Forms.Button btnSpamMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnKetbanMenu;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}