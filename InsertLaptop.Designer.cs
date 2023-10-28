namespace Prog2Start
{
    partial class InsertLaptop
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
            this.createLaptopButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.laptopCpuPD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.laptopCpuSock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.laptopCpuCS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.laptopCpuMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.laptopCpuMan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laptopMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laptopMan = new System.Windows.Forms.TextBox();
            this.laptopFixedTdp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createLaptopButton
            // 
            this.createLaptopButton.Location = new System.Drawing.Point(111, 407);
            this.createLaptopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createLaptopButton.Name = "createLaptopButton";
            this.createLaptopButton.Size = new System.Drawing.Size(112, 37);
            this.createLaptopButton.TabIndex = 57;
            this.createLaptopButton.Text = "Create";
            this.createLaptopButton.UseVisualStyleBackColor = true;
            this.createLaptopButton.Click += new System.EventHandler(this.createLaptopButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Power Draw:";
            // 
            // laptopCpuPD
            // 
            this.laptopCpuPD.Location = new System.Drawing.Point(123, 177);
            this.laptopCpuPD.Name = "laptopCpuPD";
            this.laptopCpuPD.Size = new System.Drawing.Size(136, 26);
            this.laptopCpuPD.TabIndex = 55;
            this.laptopCpuPD.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.laptopCpuPD.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.laptopCpuPD.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Socket:";
            // 
            // laptopCpuSock
            // 
            this.laptopCpuSock.Location = new System.Drawing.Point(123, 140);
            this.laptopCpuSock.Name = "laptopCpuSock";
            this.laptopCpuSock.Size = new System.Drawing.Size(136, 26);
            this.laptopCpuSock.TabIndex = 53;
            this.laptopCpuSock.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.laptopCpuSock.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.laptopCpuSock.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Clock Speed:";
            // 
            // laptopCpuCS
            // 
            this.laptopCpuCS.Location = new System.Drawing.Point(123, 103);
            this.laptopCpuCS.Name = "laptopCpuCS";
            this.laptopCpuCS.Size = new System.Drawing.Size(136, 26);
            this.laptopCpuCS.TabIndex = 51;
            this.laptopCpuCS.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.laptopCpuCS.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.laptopCpuCS.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Model:";
            // 
            // laptopCpuMod
            // 
            this.laptopCpuMod.Location = new System.Drawing.Point(123, 66);
            this.laptopCpuMod.Name = "laptopCpuMod";
            this.laptopCpuMod.Size = new System.Drawing.Size(136, 26);
            this.laptopCpuMod.TabIndex = 49;
            this.laptopCpuMod.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.laptopCpuMod.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.laptopCpuMod.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Manufacturer:";
            // 
            // laptopCpuMan
            // 
            this.laptopCpuMan.Location = new System.Drawing.Point(123, 29);
            this.laptopCpuMan.Name = "laptopCpuMan";
            this.laptopCpuMan.Size = new System.Drawing.Size(136, 26);
            this.laptopCpuMan.TabIndex = 47;
            this.laptopCpuMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.laptopCpuMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.laptopCpuMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Fixed TDP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Model:";
            // 
            // laptopMod
            // 
            this.laptopMod.Location = new System.Drawing.Point(147, 72);
            this.laptopMod.Name = "laptopMod";
            this.laptopMod.Size = new System.Drawing.Size(136, 26);
            this.laptopMod.TabIndex = 42;
            this.laptopMod.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.laptopMod.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.laptopMod.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Manufacturer:";
            // 
            // laptopMan
            // 
            this.laptopMan.Location = new System.Drawing.Point(147, 32);
            this.laptopMan.Name = "laptopMan";
            this.laptopMan.Size = new System.Drawing.Size(136, 26);
            this.laptopMan.TabIndex = 40;
            this.laptopMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.laptopMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.laptopMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // laptopFixedTdp
            // 
            this.laptopFixedTdp.Location = new System.Drawing.Point(147, 115);
            this.laptopFixedTdp.Name = "laptopFixedTdp";
            this.laptopFixedTdp.Size = new System.Drawing.Size(136, 26);
            this.laptopFixedTdp.TabIndex = 58;
            this.laptopFixedTdp.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.laptopFixedTdp.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.laptopFixedTdp.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laptopCpuPD);
            this.groupBox1.Controls.Add(this.laptopCpuMan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.laptopCpuMod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.laptopCpuCS);
            this.groupBox1.Controls.Add(this.laptopCpuSock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(24, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 219);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Information";
            // 
            // InsertLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.laptopFixedTdp);
            this.Controls.Add(this.createLaptopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laptopMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laptopMan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertLaptop";
            this.Text = "Create Laptop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createLaptopButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox laptopCpuPD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox laptopCpuSock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox laptopCpuCS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox laptopCpuMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox laptopCpuMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox laptopMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox laptopMan;
        private System.Windows.Forms.TextBox laptopFixedTdp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}