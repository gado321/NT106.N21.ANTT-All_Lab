namespace Lab06
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.conversation = new System.Windows.Forms.RichTextBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.playerNum = new System.Windows.Forms.Label();
            this.autoTurn = new System.Windows.Forms.Button();
            this.autoAllGame = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.range = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ansNumber = new System.Windows.Forms.Label();
            this.timerCnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Control;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(851, 284);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(165, 60);
            this.btnSend.TabIndex = 1;
            this.btnSend.TabStop = false;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(851, 359);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 60);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.Control;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Black;
            this.message.Location = new System.Drawing.Point(177, 136);
            this.message.Margin = new System.Windows.Forms.Padding(4);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(668, 34);
            this.message.TabIndex = 0;
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_KeyDown);
            // 
            // conversation
            // 
            this.conversation.BackColor = System.Drawing.SystemColors.Control;
            this.conversation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversation.ForeColor = System.Drawing.Color.Black;
            this.conversation.Location = new System.Drawing.Point(13, 180);
            this.conversation.Margin = new System.Windows.Forms.Padding(4);
            this.conversation.Name = "conversation";
            this.conversation.ReadOnly = true;
            this.conversation.Size = new System.Drawing.Size(832, 390);
            this.conversation.TabIndex = 0;
            this.conversation.TabStop = false;
            this.conversation.Text = "Chờ tất cả player sẵn sàng!\n";
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.SystemColors.Control;
            this.btnReady.FlatAppearance.BorderSize = 0;
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReady.ForeColor = System.Drawing.Color.Black;
            this.btnReady.Location = new System.Drawing.Point(853, 180);
            this.btnReady.Margin = new System.Windows.Forms.Padding(4);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(165, 96);
            this.btnReady.TabIndex = 0;
            this.btnReady.TabStop = false;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.SystemColors.Control;
            this.answer.Enabled = false;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.ForeColor = System.Drawing.Color.Black;
            this.answer.Location = new System.Drawing.Point(177, 36);
            this.answer.Margin = new System.Windows.Forms.Padding(4);
            this.answer.MaxLength = 3;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(80, 80);
            this.answer.TabIndex = 1;
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answer_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chat:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(265, 36);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 80);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // playerNum
            // 
            this.playerNum.BackColor = System.Drawing.SystemColors.Control;
            this.playerNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNum.Location = new System.Drawing.Point(0, 0);
            this.playerNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerNum.Name = "playerNum";
            this.playerNum.Size = new System.Drawing.Size(1031, 32);
            this.playerNum.TabIndex = 7;
            this.playerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoTurn
            // 
            this.autoTurn.BackColor = System.Drawing.SystemColors.Control;
            this.autoTurn.Enabled = false;
            this.autoTurn.FlatAppearance.BorderSize = 0;
            this.autoTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.autoTurn.ForeColor = System.Drawing.Color.Black;
            this.autoTurn.Location = new System.Drawing.Point(400, 36);
            this.autoTurn.Margin = new System.Windows.Forms.Padding(0);
            this.autoTurn.Name = "autoTurn";
            this.autoTurn.Size = new System.Drawing.Size(186, 80);
            this.autoTurn.TabIndex = 9;
            this.autoTurn.TabStop = false;
            this.autoTurn.Text = "Autoplay a turn";
            this.autoTurn.UseVisualStyleBackColor = false;
            this.autoTurn.Click += new System.EventHandler(this.autoTurn_Click);
            // 
            // autoAllGame
            // 
            this.autoAllGame.BackColor = System.Drawing.SystemColors.Control;
            this.autoAllGame.Enabled = false;
            this.autoAllGame.FlatAppearance.BorderSize = 0;
            this.autoAllGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.autoAllGame.ForeColor = System.Drawing.Color.Black;
            this.autoAllGame.Location = new System.Drawing.Point(593, 36);
            this.autoAllGame.Margin = new System.Windows.Forms.Padding(0);
            this.autoAllGame.Name = "autoAllGame";
            this.autoAllGame.Size = new System.Drawing.Size(252, 80);
            this.autoAllGame.TabIndex = 10;
            this.autoAllGame.TabStop = false;
            this.autoAllGame.Text = "Autoplay all rounds";
            this.autoAllGame.UseVisualStyleBackColor = false;
            this.autoAllGame.Click += new System.EventHandler(this.autoAllGame_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(853, 448);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Khoảng:";
            // 
            // range
            // 
            this.range.AutoSize = true;
            this.range.Enabled = false;
            this.range.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range.Location = new System.Drawing.Point(926, 448);
            this.range.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(0, 22);
            this.range.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(856, 478);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đáp án:";
            // 
            // ansNumber
            // 
            this.ansNumber.AutoSize = true;
            this.ansNumber.Enabled = false;
            this.ansNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansNumber.Location = new System.Drawing.Point(938, 478);
            this.ansNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ansNumber.Name = "ansNumber";
            this.ansNumber.Size = new System.Drawing.Size(0, 22);
            this.ansNumber.TabIndex = 15;
            // 
            // timerCnt
            // 
            this.timerCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerCnt.Location = new System.Drawing.Point(855, 42);
            this.timerCnt.Name = "timerCnt";
            this.timerCnt.Size = new System.Drawing.Size(164, 134);
            this.timerCnt.TabIndex = 16;
            this.timerCnt.Text = "X";
            this.timerCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1031, 608);
            this.Controls.Add(this.timerCnt);
            this.Controls.Add(this.autoTurn);
            this.Controls.Add(this.ansNumber);
            this.Controls.Add(this.autoAllGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.range);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerNum);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.conversation);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox message;
        public System.Windows.Forms.RichTextBox conversation;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label playerNum;
        private System.Windows.Forms.Button autoTurn;
        private System.Windows.Forms.Button autoAllGame;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label range;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ansNumber;
        private System.Windows.Forms.Label timerCnt;
    }
}