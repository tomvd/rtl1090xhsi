namespace rtl1090XHSI
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtICAO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCS = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLATLON = new System.Windows.Forms.Label();
            this.lblFL = new System.Windows.Forms.Label();
            this.lblAC = new System.Windows.Forms.Label();
            this.lblVR = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblIAS = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.lblMCP = new System.Windows.Forms.Label();
            this.lblHDG = new System.Windows.Forms.Label();
            this.lblTAS = new System.Windows.Forms.Label();
            this.lblTR = new System.Windows.Forms.Label();
            this.lblGS = new System.Windows.Forms.Label();
            this.lblMACH = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1473, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtICAO
            // 
            this.txtICAO.Location = new System.Drawing.Point(24, 8);
            this.txtICAO.Name = "txtICAO";
            this.txtICAO.Size = new System.Drawing.Size(100, 20);
            this.txtICAO.TabIndex = 2;
            this.txtICAO.Text = "ICAO";
            this.txtICAO.TextChanged += new System.EventHandler(this.txtICAO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Callsign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SQUAWK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "LAT/LON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Flight Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Altitude";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vertical Rate";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "True Track";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Heading";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Indicated Airspeed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "True Air Speed";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(319, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ground Speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(482, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mach";
            this.label12.Click += new System.EventHandler(this.label2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Bank Angle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(177, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Turn Rate";
            this.label14.Click += new System.EventHandler(this.label2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(482, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Autopilot";
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Location = new System.Drawing.Point(24, 83);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(31, 13);
            this.lblCS.TabIndex = 4;
            this.lblCS.Text = "lblCS";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(177, 83);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "lblID";
            // 
            // lblLATLON
            // 
            this.lblLATLON.AutoSize = true;
            this.lblLATLON.Location = new System.Drawing.Point(24, 121);
            this.lblLATLON.Name = "lblLATLON";
            this.lblLATLON.Size = new System.Drawing.Size(59, 13);
            this.lblLATLON.TabIndex = 4;
            this.lblLATLON.Text = "lblLATLON";
            // 
            // lblFL
            // 
            this.lblFL.AutoSize = true;
            this.lblFL.Location = new System.Drawing.Point(24, 161);
            this.lblFL.Name = "lblFL";
            this.lblFL.Size = new System.Drawing.Size(29, 13);
            this.lblFL.TabIndex = 4;
            this.lblFL.Text = "lblFL";
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Location = new System.Drawing.Point(177, 161);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(31, 13);
            this.lblAC.TabIndex = 4;
            this.lblAC.Text = "lblAC";
            // 
            // lblVR
            // 
            this.lblVR.AutoSize = true;
            this.lblVR.Location = new System.Drawing.Point(319, 161);
            this.lblVR.Name = "lblVR";
            this.lblVR.Size = new System.Drawing.Size(32, 13);
            this.lblVR.TabIndex = 4;
            this.lblVR.Text = "lblVR";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(24, 208);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(31, 13);
            this.lblTT.TabIndex = 4;
            this.lblTT.Text = "lblTT";
            // 
            // lblIAS
            // 
            this.lblIAS.AutoSize = true;
            this.lblIAS.Location = new System.Drawing.Point(24, 250);
            this.lblIAS.Name = "lblIAS";
            this.lblIAS.Size = new System.Drawing.Size(34, 13);
            this.lblIAS.TabIndex = 4;
            this.lblIAS.Text = "lblIAS";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(24, 288);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(32, 13);
            this.lblRA.TabIndex = 4;
            this.lblRA.Text = "lblRA";
            // 
            // lblMCP
            // 
            this.lblMCP.AutoSize = true;
            this.lblMCP.Location = new System.Drawing.Point(485, 161);
            this.lblMCP.Name = "lblMCP";
            this.lblMCP.Size = new System.Drawing.Size(40, 13);
            this.lblMCP.TabIndex = 4;
            this.lblMCP.Text = "lblMCP";
            // 
            // lblHDG
            // 
            this.lblHDG.AutoSize = true;
            this.lblHDG.Location = new System.Drawing.Point(177, 208);
            this.lblHDG.Name = "lblHDG";
            this.lblHDG.Size = new System.Drawing.Size(41, 13);
            this.lblHDG.TabIndex = 4;
            this.lblHDG.Text = "lblHDG";
            // 
            // lblTAS
            // 
            this.lblTAS.AutoSize = true;
            this.lblTAS.Location = new System.Drawing.Point(177, 250);
            this.lblTAS.Name = "lblTAS";
            this.lblTAS.Size = new System.Drawing.Size(38, 13);
            this.lblTAS.TabIndex = 4;
            this.lblTAS.Text = "lblTAS";
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(177, 288);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(32, 13);
            this.lblTR.TabIndex = 4;
            this.lblTR.Text = "lblTR";
            // 
            // lblGS
            // 
            this.lblGS.AutoSize = true;
            this.lblGS.Location = new System.Drawing.Point(319, 250);
            this.lblGS.Name = "lblGS";
            this.lblGS.Size = new System.Drawing.Size(32, 13);
            this.lblGS.TabIndex = 4;
            this.lblGS.Text = "lblGS";
            // 
            // lblMACH
            // 
            this.lblMACH.AutoSize = true;
            this.lblMACH.Location = new System.Drawing.Point(482, 250);
            this.lblMACH.Name = "lblMACH";
            this.lblMACH.Size = new System.Drawing.Size(48, 13);
            this.lblMACH.TabIndex = 4;
            this.lblMACH.Text = "lblMACH";
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation Display Mode";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "APP";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(93, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "VOR";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(180, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "MAP";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(270, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "3";
            this.radioButton4.Text = "NAV";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(360, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(46, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Tag = "4";
            this.radioButton5.Text = "PLN";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblMACH);
            this.Controls.Add(this.lblGS);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.lblTAS);
            this.Controls.Add(this.lblHDG);
            this.Controls.Add(this.lblMCP);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.lblIAS);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.lblVR);
            this.Controls.Add(this.lblAC);
            this.Controls.Add(this.lblFL);
            this.Controls.Add(this.lblLATLON);
            this.Controls.Add(this.lblCS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtICAO);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "RTL1090-XHSI Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtICAO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLATLON;
        private System.Windows.Forms.Label lblFL;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Label lblVR;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblIAS;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.Label lblMCP;
        private System.Windows.Forms.Label lblHDG;
        private System.Windows.Forms.Label lblTAS;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.Label lblGS;
        private System.Windows.Forms.Label lblMACH;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;

    }
}

