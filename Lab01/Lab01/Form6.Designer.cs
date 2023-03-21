using System.Drawing;

namespace Lab01
{
    partial class Form6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDiemTB = new System.Windows.Forms.Label();
            this.labelDiemCN = new System.Windows.Forms.Label();
            this.labelDiemTN = new System.Windows.Forms.Label();
            this.labelSMD = new System.Windows.Forms.Label();
            this.labelSMKD = new System.Windows.Forms.Label();
            this.labelHocLuc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(284, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(836, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(60, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách điểm:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(941, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 59);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xuất";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(63, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Điểm trung bình:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(63, 767);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Môn có điểm cao nhất:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(63, 834);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số môn đậu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(606, 695);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Xếp loại học lực:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(606, 834);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số môn không đậu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(606, 767);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "Môn có điểm thấp nhất:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDiemTB
            // 
            this.labelDiemTB.AutoSize = true;
            this.labelDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDiemTB.Location = new System.Drawing.Point(276, 695);
            this.labelDiemTB.Name = "labelDiemTB";
            this.labelDiemTB.Size = new System.Drawing.Size(0, 31);
            this.labelDiemTB.TabIndex = 16;
            this.labelDiemTB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDiemTB.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDiemCN
            // 
            this.labelDiemCN.AutoSize = true;
            this.labelDiemCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDiemCN.Location = new System.Drawing.Point(364, 767);
            this.labelDiemCN.Name = "labelDiemCN";
            this.labelDiemCN.Size = new System.Drawing.Size(0, 31);
            this.labelDiemCN.TabIndex = 16;
            this.labelDiemCN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDiemCN.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDiemTN
            // 
            this.labelDiemTN.AutoSize = true;
            this.labelDiemTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDiemTN.Location = new System.Drawing.Point(915, 767);
            this.labelDiemTN.Name = "labelDiemTN";
            this.labelDiemTN.Size = new System.Drawing.Size(0, 31);
            this.labelDiemTN.TabIndex = 16;
            this.labelDiemTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDiemTN.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelSMD
            // 
            this.labelSMD.AutoSize = true;
            this.labelSMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSMD.Location = new System.Drawing.Point(243, 834);
            this.labelSMD.Name = "labelSMD";
            this.labelSMD.Size = new System.Drawing.Size(0, 31);
            this.labelSMD.TabIndex = 16;
            this.labelSMD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSMD.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelSMKD
            // 
            this.labelSMKD.AutoSize = true;
            this.labelSMKD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSMKD.Location = new System.Drawing.Point(862, 834);
            this.labelSMKD.Name = "labelSMKD";
            this.labelSMKD.Size = new System.Drawing.Size(0, 31);
            this.labelSMKD.TabIndex = 16;
            this.labelSMKD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSMKD.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelHocLuc
            // 
            this.labelHocLuc.AutoSize = true;
            this.labelHocLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHocLuc.Location = new System.Drawing.Point(836, 695);
            this.labelHocLuc.Name = "labelHocLuc";
            this.labelHocLuc.Size = new System.Drawing.Size(0, 31);
            this.labelHocLuc.TabIndex = 16;
            this.labelHocLuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHocLuc.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox1.Location = new System.Drawing.Point(64, 273);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1056, 383);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học và điểm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.MaximumSize = new System.Drawing.Size(900, 938);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(0, 26);
            this.label8.TabIndex = 0;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(367, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(469, 46);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phần mềm quản lý điểm";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 931);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDiemTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDiemCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSMKD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelHocLuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSMD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDiemTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Câu 5";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDiemTB;
        private System.Windows.Forms.Label labelDiemCN;
        private System.Windows.Forms.Label labelDiemTN;
        private System.Windows.Forms.Label labelSMD;
        private System.Windows.Forms.Label labelSMKD;
        private System.Windows.Forms.Label labelHocLuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}