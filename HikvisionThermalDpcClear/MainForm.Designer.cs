namespace HikvisionThermalDpcClear
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
			this.nudTop = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudLeft = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.nudHeight = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.nudWidth = new System.Windows.Forms.NumericUpDown();
			this.lblDescription = new System.Windows.Forms.Label();
			this.btnProceed = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtCamIP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nudPort = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblPosition = new System.Windows.Forms.Label();
			this.lblCompleted = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.nudNativeHeight = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.nudNativeWidth = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.cbShowPW = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nudTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNativeHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNativeWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// nudTop
			// 
			this.nudTop.Location = new System.Drawing.Point(60, 12);
			this.nudTop.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudTop.Name = "nudTop";
			this.nudTop.Size = new System.Drawing.Size(120, 20);
			this.nudTop.TabIndex = 0;
			this.nudTop.ValueChanged += new System.EventHandler(this.nudDimValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Top:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Left:";
			// 
			// nudLeft
			// 
			this.nudLeft.Location = new System.Drawing.Point(60, 38);
			this.nudLeft.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudLeft.Name = "nudLeft";
			this.nudLeft.Size = new System.Drawing.Size(120, 20);
			this.nudLeft.TabIndex = 2;
			this.nudLeft.ValueChanged += new System.EventHandler(this.nudDimValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Height:";
			// 
			// nudHeight
			// 
			this.nudHeight.Location = new System.Drawing.Point(60, 90);
			this.nudHeight.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudHeight.Name = "nudHeight";
			this.nudHeight.Size = new System.Drawing.Size(120, 20);
			this.nudHeight.TabIndex = 6;
			this.nudHeight.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.nudHeight.ValueChanged += new System.EventHandler(this.nudDimValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Width:";
			// 
			// nudWidth
			// 
			this.nudWidth.Location = new System.Drawing.Point(60, 64);
			this.nudWidth.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudWidth.Name = "nudWidth";
			this.nudWidth.Size = new System.Drawing.Size(120, 20);
			this.nudWidth.TabIndex = 4;
			this.nudWidth.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.nudWidth.ValueChanged += new System.EventHandler(this.nudDimValueChanged);
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(12, 173);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(776, 90);
			this.lblDescription.TabIndex = 8;
			this.lblDescription.Text = "A description goes here.";
			// 
			// btnProceed
			// 
			this.btnProceed.Location = new System.Drawing.Point(336, 266);
			this.btnProceed.Name = "btnProceed";
			this.btnProceed.Size = new System.Drawing.Size(75, 23);
			this.btnProceed.TabIndex = 28;
			this.btnProceed.Text = "Proceed";
			this.btnProceed.UseVisualStyleBackColor = true;
			this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(12, 292);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(776, 23);
			this.lblStatus.TabIndex = 10;
			this.lblStatus.Text = "Status goes here";
			// 
			// txtCamIP
			// 
			this.txtCamIP.Location = new System.Drawing.Point(336, 11);
			this.txtCamIP.Name = "txtCamIP";
			this.txtCamIP.Size = new System.Drawing.Size(150, 20);
			this.txtCamIP.TabIndex = 11;
			this.txtCamIP.Text = "10.30.4.15";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(271, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Camera IP:";
			// 
			// nudPort
			// 
			this.nudPort.Location = new System.Drawing.Point(336, 38);
			this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPort.Name = "nudPort";
			this.nudPort.Size = new System.Drawing.Size(120, 20);
			this.nudPort.TabIndex = 13;
			this.nudPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(269, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "HTTP Port:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(267, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "User Name:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(336, 64);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(150, 20);
			this.txtUser.TabIndex = 15;
			this.txtUser.Text = "admin";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(274, 93);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "Password:";
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(336, 90);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(150, 20);
			this.txtPass.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(16, 331);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(84, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "Current Position:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(31, 354);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "Completed:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(57, 377);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 13);
			this.label11.TabIndex = 21;
			this.label11.Text = "Total:";
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Location = new System.Drawing.Point(106, 331);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(16, 13);
			this.lblPosition.TabIndex = 22;
			this.lblPosition.Text = "...";
			// 
			// lblCompleted
			// 
			this.lblCompleted.AutoSize = true;
			this.lblCompleted.Location = new System.Drawing.Point(106, 354);
			this.lblCompleted.Name = "lblCompleted";
			this.lblCompleted.Size = new System.Drawing.Size(16, 13);
			this.lblCompleted.TabIndex = 23;
			this.lblCompleted.Text = "...";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(106, 377);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(16, 13);
			this.lblTotal.TabIndex = 24;
			this.lblTotal.Text = "...";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(568, 66);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 13);
			this.label12.TabIndex = 28;
			this.label12.Text = "Height:";
			// 
			// nudNativeHeight
			// 
			this.nudNativeHeight.Location = new System.Drawing.Point(615, 64);
			this.nudNativeHeight.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudNativeHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudNativeHeight.Name = "nudNativeHeight";
			this.nudNativeHeight.Size = new System.Drawing.Size(120, 20);
			this.nudNativeHeight.TabIndex = 27;
			this.nudNativeHeight.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.nudNativeHeight.ValueChanged += new System.EventHandler(this.nudDimValueChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(571, 40);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 13);
			this.label13.TabIndex = 26;
			this.label13.Text = "Width:";
			// 
			// nudNativeWidth
			// 
			this.nudNativeWidth.Location = new System.Drawing.Point(615, 38);
			this.nudNativeWidth.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudNativeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudNativeWidth.Name = "nudNativeWidth";
			this.nudNativeWidth.Size = new System.Drawing.Size(120, 20);
			this.nudNativeWidth.TabIndex = 25;
			this.nudNativeWidth.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.nudNativeWidth.ValueChanged += new System.EventHandler(this.nudDimValueChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(544, 17);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(135, 13);
			this.label14.TabIndex = 29;
			this.label14.Text = "Native Thermal Resolution:";
			// 
			// cbShowPW
			// 
			this.cbShowPW.AutoSize = true;
			this.cbShowPW.Location = new System.Drawing.Point(361, 116);
			this.cbShowPW.Name = "cbShowPW";
			this.cbShowPW.Size = new System.Drawing.Size(102, 17);
			this.cbShowPW.TabIndex = 18;
			this.cbShowPW.Text = "Show Password";
			this.cbShowPW.UseVisualStyleBackColor = true;
			this.cbShowPW.CheckedChanged += new System.EventHandler(this.cbShowPW_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbShowPW);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.nudNativeHeight);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.nudNativeWidth);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblCompleted);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nudPort);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCamIP);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnProceed);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudHeight);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nudWidth);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nudLeft);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Hikvision Thermal Camera DPC Clear";
			((System.ComponentModel.ISupportInitialize)(this.nudTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNativeHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNativeWidth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudTop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudLeft;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudHeight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudWidth;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Button btnProceed;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TextBox txtCamIP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudPort;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.Label lblCompleted;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown nudNativeHeight;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown nudNativeWidth;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox cbShowPW;
	}
}

