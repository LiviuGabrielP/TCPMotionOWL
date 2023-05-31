namespace TCPMotionOWL
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.cwBtn = new System.Windows.Forms.Button();
            this.ccwBtn = new System.Windows.Forms.Button();
            this.lhdLeftBtn = new System.Windows.Forms.Button();
            this.lhdRightBtn = new System.Windows.Forms.Button();
            this.beltLeftBtn = new System.Windows.Forms.Button();
            this.beltRightBtn = new System.Windows.Forms.Button();
            this.slowDownBtn = new System.Windows.Forms.Button();
            this.speedUpBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ipAddr_tb = new System.Windows.Forms.TextBox();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1535, 1);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1535, 1);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(1544, 1);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(1, 783);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(1543, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 783);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(1, 783);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(1);
            this.label6.Size = new System.Drawing.Size(1542, 1);
            this.label6.TabIndex = 5;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(106, 399);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(192, 72);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "START X-DRIVE";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cwBtn
            // 
            this.cwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cwBtn.Location = new System.Drawing.Point(106, 529);
            this.cwBtn.Name = "cwBtn";
            this.cwBtn.Size = new System.Drawing.Size(192, 72);
            this.cwBtn.TabIndex = 7;
            this.cwBtn.Text = "MOVE CLOCKWISE";
            this.cwBtn.UseVisualStyleBackColor = true;
            this.cwBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ccwBtn
            // 
            this.ccwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccwBtn.Location = new System.Drawing.Point(106, 663);
            this.ccwBtn.Name = "ccwBtn";
            this.ccwBtn.Size = new System.Drawing.Size(192, 72);
            this.ccwBtn.TabIndex = 8;
            this.ccwBtn.Text = "MOVE COUNTERCLOCKWISE";
            this.ccwBtn.UseVisualStyleBackColor = true;
            this.ccwBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lhdLeftBtn
            // 
            this.lhdLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhdLeftBtn.Location = new System.Drawing.Point(470, 399);
            this.lhdLeftBtn.Name = "lhdLeftBtn";
            this.lhdLeftBtn.Size = new System.Drawing.Size(192, 125);
            this.lhdLeftBtn.TabIndex = 9;
            this.lhdLeftBtn.Text = "LHD_LEFT";
            this.lhdLeftBtn.UseVisualStyleBackColor = true;
            this.lhdLeftBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lhdRightBtn
            // 
            this.lhdRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhdRightBtn.Location = new System.Drawing.Point(746, 399);
            this.lhdRightBtn.Name = "lhdRightBtn";
            this.lhdRightBtn.Size = new System.Drawing.Size(192, 125);
            this.lhdRightBtn.TabIndex = 10;
            this.lhdRightBtn.Text = "LHD_RIGHT";
            this.lhdRightBtn.UseVisualStyleBackColor = true;
            this.lhdRightBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // beltLeftBtn
            // 
            this.beltLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beltLeftBtn.Location = new System.Drawing.Point(470, 610);
            this.beltLeftBtn.Name = "beltLeftBtn";
            this.beltLeftBtn.Size = new System.Drawing.Size(192, 125);
            this.beltLeftBtn.TabIndex = 11;
            this.beltLeftBtn.Text = "BELT_LEFT";
            this.beltLeftBtn.UseVisualStyleBackColor = true;
            this.beltLeftBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // beltRightBtn
            // 
            this.beltRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beltRightBtn.Location = new System.Drawing.Point(746, 610);
            this.beltRightBtn.Name = "beltRightBtn";
            this.beltRightBtn.Size = new System.Drawing.Size(192, 125);
            this.beltRightBtn.TabIndex = 12;
            this.beltRightBtn.Text = "BELT_RIGHT";
            this.beltRightBtn.UseVisualStyleBackColor = true;
            this.beltRightBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // slowDownBtn
            // 
            this.slowDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowDownBtn.Location = new System.Drawing.Point(1171, 663);
            this.slowDownBtn.Name = "slowDownBtn";
            this.slowDownBtn.Size = new System.Drawing.Size(192, 72);
            this.slowDownBtn.TabIndex = 13;
            this.slowDownBtn.Text = "SLOW DOWN";
            this.slowDownBtn.UseVisualStyleBackColor = true;
            this.slowDownBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // speedUpBtn
            // 
            this.speedUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedUpBtn.Location = new System.Drawing.Point(1171, 399);
            this.speedUpBtn.Name = "speedUpBtn";
            this.speedUpBtn.Size = new System.Drawing.Size(192, 192);
            this.speedUpBtn.TabIndex = 14;
            this.speedUpBtn.Text = "SPEED UP";
            this.speedUpBtn.UseVisualStyleBackColor = true;
            this.speedUpBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(426, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 423);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(983, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 423);
            this.label8.TabIndex = 16;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.IndianRed;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.Location = new System.Drawing.Point(12, 100);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(1520, 234);
            this.stopBtn.TabIndex = 17;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(429, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(555, 1);
            this.label9.TabIndex = 18;
            // 
            // ipAddr_tb
            // 
            this.ipAddr_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddr_tb.Location = new System.Drawing.Point(223, 24);
            this.ipAddr_tb.Name = "ipAddr_tb";
            this.ipAddr_tb.Size = new System.Drawing.Size(270, 38);
            this.ipAddr_tb.TabIndex = 19;
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(626, 27);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(116, 38);
            this.port_tb.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 32);
            this.label10.TabIndex = 21;
            this.label10.Text = "IP ADDRESS : ";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(1202, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 78);
            this.label11.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(506, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 32);
            this.label12.TabIndex = 23;
            this.label12.Text = "PORT : ";
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(810, 21);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(174, 41);
            this.connectBtn.TabIndex = 24;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(775, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1, 78);
            this.label13.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1223, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 32);
            this.label14.TabIndex = 27;
            this.label14.Text = "Status: ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(1339, 30);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(179, 32);
            this.labelStatus.TabIndex = 28;
            this.labelStatus.Text = "[placeholder]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 784);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.ipAddr_tb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.speedUpBtn);
            this.Controls.Add(this.slowDownBtn);
            this.Controls.Add(this.beltRightBtn);
            this.Controls.Add(this.beltLeftBtn);
            this.Controls.Add(this.lhdRightBtn);
            this.Controls.Add(this.lhdLeftBtn);
            this.Controls.Add(this.ccwBtn);
            this.Controls.Add(this.cwBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button cwBtn;
        private System.Windows.Forms.Button ccwBtn;
        private System.Windows.Forms.Button lhdLeftBtn;
        private System.Windows.Forms.Button lhdRightBtn;
        private System.Windows.Forms.Button beltLeftBtn;
        private System.Windows.Forms.Button beltRightBtn;
        private System.Windows.Forms.Button slowDownBtn;
        private System.Windows.Forms.Button speedUpBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ipAddr_tb;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelStatus;
    }
}

