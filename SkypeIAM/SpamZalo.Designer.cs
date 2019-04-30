namespace ZaloSpammer
{
    partial class SpamZalo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBatdau = new System.Windows.Forms.Button();
            this.rbLogs = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDanhsachnguoigui = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelaytime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSolanSpam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoidunggui = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBatdau);
            this.groupBox3.Controls.Add(this.rbLogs);
            this.groupBox3.Location = new System.Drawing.Point(313, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 241);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiến trình làm việc";
            // 
            // btnBatdau
            // 
            this.btnBatdau.AutoSize = true;
            this.btnBatdau.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBatdau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatdau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatdau.ForeColor = System.Drawing.Color.White;
            this.btnBatdau.Location = new System.Drawing.Point(10, 192);
            this.btnBatdau.Name = "btnBatdau";
            this.btnBatdau.Size = new System.Drawing.Size(151, 43);
            this.btnBatdau.TabIndex = 1;
            this.btnBatdau.Text = "BẮT ĐẦU";
            this.btnBatdau.UseVisualStyleBackColor = false;
            this.btnBatdau.Click += new System.EventHandler(this.BtnBatdau_Click);
            // 
            // rbLogs
            // 
            this.rbLogs.Location = new System.Drawing.Point(10, 25);
            this.rbLogs.Name = "rbLogs";
            this.rbLogs.Size = new System.Drawing.Size(390, 161);
            this.rbLogs.TabIndex = 0;
            this.rbLogs.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDanhsachnguoigui);
            this.groupBox2.Location = new System.Drawing.Point(9, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 508);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List người gửi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách người dùng";
            // 
            // txtDanhsachnguoigui
            // 
            this.txtDanhsachnguoigui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDanhsachnguoigui.Location = new System.Drawing.Point(9, 49);
            this.txtDanhsachnguoigui.Name = "txtDanhsachnguoigui";
            this.txtDanhsachnguoigui.Size = new System.Drawing.Size(282, 453);
            this.txtDanhsachnguoigui.TabIndex = 0;
            this.txtDanhsachnguoigui.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDelaytime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSolanSpam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNoidunggui);
            this.groupBox1.Location = new System.Drawing.Point(313, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 261);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tin nhắn gửi";
            // 
            // txtDelaytime
            // 
            this.txtDelaytime.Location = new System.Drawing.Point(121, 209);
            this.txtDelaytime.Name = "txtDelaytime";
            this.txtDelaytime.Size = new System.Drawing.Size(239, 26);
            this.txtDelaytime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lần spam";
            // 
            // txtSolanSpam
            // 
            this.txtSolanSpam.Location = new System.Drawing.Point(121, 175);
            this.txtSolanSpam.Name = "txtSolanSpam";
            this.txtSolanSpam.Size = new System.Drawing.Size(239, 26);
            this.txtSolanSpam.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "lần";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "phút";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Delay time";
            // 
            // txtNoidunggui
            // 
            this.txtNoidunggui.Location = new System.Drawing.Point(10, 49);
            this.txtNoidunggui.Name = "txtNoidunggui";
            this.txtNoidunggui.Size = new System.Drawing.Size(390, 116);
            this.txtNoidunggui.TabIndex = 2;
            this.txtNoidunggui.Text = "";
            // 
            // SpamZalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpamZalo";
            this.Text = "SpamZalo";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBatdau;
        private System.Windows.Forms.RichTextBox rbLogs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDanhsachnguoigui;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDelaytime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSolanSpam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtNoidunggui;
    }
}