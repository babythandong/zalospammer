namespace ZaloSpammer
{
    partial class KetBanZalo
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
            this.btnBatdau1 = new System.Windows.Forms.Button();
            this.rbLogs1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDanhsachnguoigui1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoidunggui1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBatdau1);
            this.groupBox3.Controls.Add(this.rbLogs1);
            this.groupBox3.Location = new System.Drawing.Point(313, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 293);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiến trình làm việc";
            // 
            // btnBatdau1
            // 
            this.btnBatdau1.AutoSize = true;
            this.btnBatdau1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBatdau1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatdau1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatdau1.ForeColor = System.Drawing.Color.White;
            this.btnBatdau1.Location = new System.Drawing.Point(10, 244);
            this.btnBatdau1.Name = "btnBatdau1";
            this.btnBatdau1.Size = new System.Drawing.Size(151, 43);
            this.btnBatdau1.TabIndex = 1;
            this.btnBatdau1.Text = "BẮT ĐẦU";
            this.btnBatdau1.UseVisualStyleBackColor = false;
            this.btnBatdau1.Click += new System.EventHandler(this.BtnBatdau1_Click);
            // 
            // rbLogs1
            // 
            this.rbLogs1.Location = new System.Drawing.Point(10, 25);
            this.rbLogs1.Name = "rbLogs1";
            this.rbLogs1.Size = new System.Drawing.Size(390, 213);
            this.rbLogs1.TabIndex = 0;
            this.rbLogs1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDanhsachnguoigui1);
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
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách kết bạn";
            // 
            // txtDanhsachnguoigui1
            // 
            this.txtDanhsachnguoigui1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDanhsachnguoigui1.Location = new System.Drawing.Point(9, 49);
            this.txtDanhsachnguoigui1.Name = "txtDanhsachnguoigui1";
            this.txtDanhsachnguoigui1.Size = new System.Drawing.Size(282, 453);
            this.txtDanhsachnguoigui1.TabIndex = 0;
            this.txtDanhsachnguoigui1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoidunggui1);
            this.groupBox1.Location = new System.Drawing.Point(313, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 209);
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
            // txtNoidunggui1
            // 
            this.txtNoidunggui1.Location = new System.Drawing.Point(10, 49);
            this.txtNoidunggui1.Name = "txtNoidunggui1";
            this.txtNoidunggui1.Size = new System.Drawing.Size(390, 147);
            this.txtNoidunggui1.TabIndex = 2;
            this.txtNoidunggui1.Text = "";
            // 
            // KetBanZalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KetBanZalo";
            this.Text = "KetBanZalo";
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
        private System.Windows.Forms.Button btnBatdau1;
        private System.Windows.Forms.RichTextBox rbLogs1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDanhsachnguoigui1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNoidunggui1;
    }
}