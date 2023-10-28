namespace Prog2Start
{
    partial class InsertAllInOne
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
            this.createAllInOneButton = new System.Windows.Forms.Button();
            this.aioScreenXSize = new System.Windows.Forms.Label();
            this.aioScreenYSize = new System.Windows.Forms.Label();
            this.aioScreenY = new System.Windows.Forms.TextBox();
            this.aioScreenX = new System.Windows.Forms.TextBox();
            this.GPUPowerDraw = new System.Windows.Forms.Label();
            this.aioGpuPD = new System.Windows.Forms.TextBox();
            this.GPUVRAM = new System.Windows.Forms.Label();
            this.aioGpuV = new System.Windows.Forms.TextBox();
            this.GPUModel = new System.Windows.Forms.Label();
            this.aioGpuMod = new System.Windows.Forms.TextBox();
            this.GPUManufacturer = new System.Windows.Forms.Label();
            this.aioGpuMan = new System.Windows.Forms.TextBox();
            this.mbPowerDraw = new System.Windows.Forms.Label();
            this.aioMbPD = new System.Windows.Forms.TextBox();
            this.mbSocket = new System.Windows.Forms.Label();
            this.aioMbSock = new System.Windows.Forms.TextBox();
            this.mbModel = new System.Windows.Forms.Label();
            this.aioMbMod = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.aioMbMan = new System.Windows.Forms.TextBox();
            this.aioCpuPowerDraw = new System.Windows.Forms.Label();
            this.aioCpuPD = new System.Windows.Forms.TextBox();
            this.aioCpuSocket = new System.Windows.Forms.Label();
            this.aioCpuSock = new System.Windows.Forms.TextBox();
            this.aioCpuClockSpeed = new System.Windows.Forms.Label();
            this.aioCpuCS = new System.Windows.Forms.TextBox();
            this.aioCpuModel = new System.Windows.Forms.Label();
            this.aioCpuMod = new System.Windows.Forms.TextBox();
            this.aioCpuManufacturer = new System.Windows.Forms.Label();
            this.aioCpuMan = new System.Windows.Forms.TextBox();
            this.aioNumOfFans = new System.Windows.Forms.Label();
            this.aioNumFans = new System.Windows.Forms.TextBox();
            this.aioManufacturer = new System.Windows.Forms.Label();
            this.aioMan = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createAllInOneButton
            // 
            this.createAllInOneButton.Location = new System.Drawing.Point(280, 485);
            this.createAllInOneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createAllInOneButton.Name = "createAllInOneButton";
            this.createAllInOneButton.Size = new System.Drawing.Size(112, 35);
            this.createAllInOneButton.TabIndex = 75;
            this.createAllInOneButton.Text = "Create";
            this.createAllInOneButton.UseVisualStyleBackColor = true;
            this.createAllInOneButton.Click += new System.EventHandler(this.createAllInOneButton_Click);
            // 
            // aioScreenXSize
            // 
            this.aioScreenXSize.AutoSize = true;
            this.aioScreenXSize.Location = new System.Drawing.Point(52, 146);
            this.aioScreenXSize.Name = "aioScreenXSize";
            this.aioScreenXSize.Size = new System.Drawing.Size(114, 20);
            this.aioScreenXSize.TabIndex = 44;
            this.aioScreenXSize.Text = "Screen X Size:";
            this.aioScreenXSize.Click += new System.EventHandler(this.label3_Click);
            // 
            // aioScreenYSize
            // 
            this.aioScreenYSize.AutoSize = true;
            this.aioScreenYSize.Location = new System.Drawing.Point(52, 190);
            this.aioScreenYSize.Name = "aioScreenYSize";
            this.aioScreenYSize.Size = new System.Drawing.Size(114, 20);
            this.aioScreenYSize.TabIndex = 76;
            this.aioScreenYSize.Text = "Screen Y Size:";
            // 
            // aioScreenY
            // 
            this.aioScreenY.Location = new System.Drawing.Point(163, 186);
            this.aioScreenY.Name = "aioScreenY";
            this.aioScreenY.Size = new System.Drawing.Size(136, 26);
            this.aioScreenY.TabIndex = 77;
            this.aioScreenY.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.aioScreenY.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioScreenY.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // aioScreenX
            // 
            this.aioScreenX.Location = new System.Drawing.Point(163, 141);
            this.aioScreenX.Name = "aioScreenX";
            this.aioScreenX.Size = new System.Drawing.Size(136, 26);
            this.aioScreenX.TabIndex = 78;
            this.aioScreenX.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.aioScreenX.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.aioScreenX.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // GPUPowerDraw
            // 
            this.GPUPowerDraw.AutoSize = true;
            this.GPUPowerDraw.Location = new System.Drawing.Point(12, 177);
            this.GPUPowerDraw.Name = "GPUPowerDraw";
            this.GPUPowerDraw.Size = new System.Drawing.Size(98, 20);
            this.GPUPowerDraw.TabIndex = 113;
            this.GPUPowerDraw.Text = "Power Draw:";
            // 
            // aioGpuPD
            // 
            this.aioGpuPD.Location = new System.Drawing.Point(123, 171);
            this.aioGpuPD.Name = "aioGpuPD";
            this.aioGpuPD.Size = new System.Drawing.Size(136, 26);
            this.aioGpuPD.TabIndex = 112;
            this.aioGpuPD.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.aioGpuPD.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.aioGpuPD.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // GPUVRAM
            // 
            this.GPUVRAM.AutoSize = true;
            this.GPUVRAM.Location = new System.Drawing.Point(12, 137);
            this.GPUVRAM.Name = "GPUVRAM";
            this.GPUVRAM.Size = new System.Drawing.Size(60, 20);
            this.GPUVRAM.TabIndex = 111;
            this.GPUVRAM.Text = "VRAM:";
            // 
            // aioGpuV
            // 
            this.aioGpuV.Location = new System.Drawing.Point(123, 131);
            this.aioGpuV.Name = "aioGpuV";
            this.aioGpuV.Size = new System.Drawing.Size(136, 26);
            this.aioGpuV.TabIndex = 110;
            this.aioGpuV.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioGpuV.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioGpuV.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // GPUModel
            // 
            this.GPUModel.AutoSize = true;
            this.GPUModel.Location = new System.Drawing.Point(12, 100);
            this.GPUModel.Name = "GPUModel";
            this.GPUModel.Size = new System.Drawing.Size(56, 20);
            this.GPUModel.TabIndex = 109;
            this.GPUModel.Text = "Model:";
            // 
            // aioGpuMod
            // 
            this.aioGpuMod.Location = new System.Drawing.Point(123, 94);
            this.aioGpuMod.Name = "aioGpuMod";
            this.aioGpuMod.Size = new System.Drawing.Size(136, 26);
            this.aioGpuMod.TabIndex = 108;
            this.aioGpuMod.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioGpuMod.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioGpuMod.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // GPUManufacturer
            // 
            this.GPUManufacturer.AutoSize = true;
            this.GPUManufacturer.Location = new System.Drawing.Point(12, 63);
            this.GPUManufacturer.Name = "GPUManufacturer";
            this.GPUManufacturer.Size = new System.Drawing.Size(108, 20);
            this.GPUManufacturer.TabIndex = 107;
            this.GPUManufacturer.Text = "Manufacturer:";
            // 
            // aioGpuMan
            // 
            this.aioGpuMan.Location = new System.Drawing.Point(123, 57);
            this.aioGpuMan.Name = "aioGpuMan";
            this.aioGpuMan.Size = new System.Drawing.Size(136, 26);
            this.aioGpuMan.TabIndex = 106;
            this.aioGpuMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioGpuMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioGpuMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // mbPowerDraw
            // 
            this.mbPowerDraw.AutoSize = true;
            this.mbPowerDraw.Location = new System.Drawing.Point(12, 149);
            this.mbPowerDraw.Name = "mbPowerDraw";
            this.mbPowerDraw.Size = new System.Drawing.Size(98, 20);
            this.mbPowerDraw.TabIndex = 104;
            this.mbPowerDraw.Text = "Power Draw:";
            // 
            // aioMbPD
            // 
            this.aioMbPD.Location = new System.Drawing.Point(123, 143);
            this.aioMbPD.Name = "aioMbPD";
            this.aioMbPD.Size = new System.Drawing.Size(136, 26);
            this.aioMbPD.TabIndex = 103;
            this.aioMbPD.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.aioMbPD.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.aioMbPD.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // mbSocket
            // 
            this.mbSocket.AutoSize = true;
            this.mbSocket.Location = new System.Drawing.Point(12, 112);
            this.mbSocket.Name = "mbSocket";
            this.mbSocket.Size = new System.Drawing.Size(63, 20);
            this.mbSocket.TabIndex = 102;
            this.mbSocket.Text = "Socket:";
            // 
            // aioMbSock
            // 
            this.aioMbSock.Location = new System.Drawing.Point(123, 106);
            this.aioMbSock.Name = "aioMbSock";
            this.aioMbSock.Size = new System.Drawing.Size(136, 26);
            this.aioMbSock.TabIndex = 101;
            this.aioMbSock.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioMbSock.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioMbSock.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // mbModel
            // 
            this.mbModel.AutoSize = true;
            this.mbModel.Location = new System.Drawing.Point(12, 69);
            this.mbModel.Name = "mbModel";
            this.mbModel.Size = new System.Drawing.Size(56, 20);
            this.mbModel.TabIndex = 100;
            this.mbModel.Text = "Model:";
            // 
            // aioMbMod
            // 
            this.aioMbMod.Location = new System.Drawing.Point(123, 63);
            this.aioMbMod.Name = "aioMbMod";
            this.aioMbMod.Size = new System.Drawing.Size(136, 26);
            this.aioMbMod.TabIndex = 99;
            this.aioMbMod.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioMbMod.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioMbMod.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 20);
            this.label22.TabIndex = 98;
            this.label22.Text = "Manufacturer:";
            // 
            // aioMbMan
            // 
            this.aioMbMan.Location = new System.Drawing.Point(123, 26);
            this.aioMbMan.Name = "aioMbMan";
            this.aioMbMan.Size = new System.Drawing.Size(136, 26);
            this.aioMbMan.TabIndex = 97;
            this.aioMbMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioMbMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioMbMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // aioCpuPowerDraw
            // 
            this.aioCpuPowerDraw.AutoSize = true;
            this.aioCpuPowerDraw.Location = new System.Drawing.Point(17, 186);
            this.aioCpuPowerDraw.Name = "aioCpuPowerDraw";
            this.aioCpuPowerDraw.Size = new System.Drawing.Size(98, 20);
            this.aioCpuPowerDraw.TabIndex = 95;
            this.aioCpuPowerDraw.Text = "Power Draw:";
            // 
            // aioCpuPD
            // 
            this.aioCpuPD.Location = new System.Drawing.Point(128, 180);
            this.aioCpuPD.Name = "aioCpuPD";
            this.aioCpuPD.Size = new System.Drawing.Size(136, 26);
            this.aioCpuPD.TabIndex = 94;
            this.aioCpuPD.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.aioCpuPD.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.aioCpuPD.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // aioCpuSocket
            // 
            this.aioCpuSocket.AutoSize = true;
            this.aioCpuSocket.Location = new System.Drawing.Point(17, 149);
            this.aioCpuSocket.Name = "aioCpuSocket";
            this.aioCpuSocket.Size = new System.Drawing.Size(63, 20);
            this.aioCpuSocket.TabIndex = 93;
            this.aioCpuSocket.Text = "Socket:";
            // 
            // aioCpuSock
            // 
            this.aioCpuSock.Location = new System.Drawing.Point(128, 143);
            this.aioCpuSock.Name = "aioCpuSock";
            this.aioCpuSock.Size = new System.Drawing.Size(136, 26);
            this.aioCpuSock.TabIndex = 92;
            this.aioCpuSock.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioCpuSock.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioCpuSock.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // aioCpuClockSpeed
            // 
            this.aioCpuClockSpeed.AutoSize = true;
            this.aioCpuClockSpeed.Location = new System.Drawing.Point(17, 113);
            this.aioCpuClockSpeed.Name = "aioCpuClockSpeed";
            this.aioCpuClockSpeed.Size = new System.Drawing.Size(103, 20);
            this.aioCpuClockSpeed.TabIndex = 91;
            this.aioCpuClockSpeed.Text = "Clock Speed:";
            // 
            // aioCpuCS
            // 
            this.aioCpuCS.Location = new System.Drawing.Point(128, 106);
            this.aioCpuCS.Name = "aioCpuCS";
            this.aioCpuCS.Size = new System.Drawing.Size(136, 26);
            this.aioCpuCS.TabIndex = 90;
            this.aioCpuCS.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.aioCpuCS.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.aioCpuCS.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // aioCpuModel
            // 
            this.aioCpuModel.AutoSize = true;
            this.aioCpuModel.Location = new System.Drawing.Point(17, 76);
            this.aioCpuModel.Name = "aioCpuModel";
            this.aioCpuModel.Size = new System.Drawing.Size(56, 20);
            this.aioCpuModel.TabIndex = 89;
            this.aioCpuModel.Text = "Model:";
            // 
            // aioCpuMod
            // 
            this.aioCpuMod.Location = new System.Drawing.Point(128, 69);
            this.aioCpuMod.Name = "aioCpuMod";
            this.aioCpuMod.Size = new System.Drawing.Size(136, 26);
            this.aioCpuMod.TabIndex = 88;
            this.aioCpuMod.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioCpuMod.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioCpuMod.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // aioCpuManufacturer
            // 
            this.aioCpuManufacturer.AutoSize = true;
            this.aioCpuManufacturer.Location = new System.Drawing.Point(17, 39);
            this.aioCpuManufacturer.Name = "aioCpuManufacturer";
            this.aioCpuManufacturer.Size = new System.Drawing.Size(108, 20);
            this.aioCpuManufacturer.TabIndex = 87;
            this.aioCpuManufacturer.Text = "Manufacturer:";
            // 
            // aioCpuMan
            // 
            this.aioCpuMan.Location = new System.Drawing.Point(128, 33);
            this.aioCpuMan.Name = "aioCpuMan";
            this.aioCpuMan.Size = new System.Drawing.Size(136, 26);
            this.aioCpuMan.TabIndex = 86;
            this.aioCpuMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioCpuMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioCpuMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // aioNumOfFans
            // 
            this.aioNumOfFans.AutoSize = true;
            this.aioNumOfFans.Location = new System.Drawing.Point(52, 109);
            this.aioNumOfFans.Name = "aioNumOfFans";
            this.aioNumOfFans.Size = new System.Drawing.Size(80, 20);
            this.aioNumOfFans.TabIndex = 82;
            this.aioNumOfFans.Text = "# of Fans:";
            // 
            // aioNumFans
            // 
            this.aioNumFans.Location = new System.Drawing.Point(163, 104);
            this.aioNumFans.Name = "aioNumFans";
            this.aioNumFans.Size = new System.Drawing.Size(136, 26);
            this.aioNumFans.TabIndex = 81;
            this.aioNumFans.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.aioNumFans.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.aioNumFans.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // aioManufacturer
            // 
            this.aioManufacturer.AutoSize = true;
            this.aioManufacturer.Location = new System.Drawing.Point(52, 69);
            this.aioManufacturer.Name = "aioManufacturer";
            this.aioManufacturer.Size = new System.Drawing.Size(108, 20);
            this.aioManufacturer.TabIndex = 80;
            this.aioManufacturer.Text = "Manufacturer:";
            // 
            // aioMan
            // 
            this.aioMan.Location = new System.Drawing.Point(163, 64);
            this.aioMan.Name = "aioMan";
            this.aioMan.Size = new System.Drawing.Size(136, 26);
            this.aioMan.TabIndex = 79;
            this.aioMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.aioMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.aioMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aioGpuPD);
            this.groupBox3.Controls.Add(this.aioGpuMan);
            this.groupBox3.Controls.Add(this.GPUManufacturer);
            this.groupBox3.Controls.Add(this.GPUPowerDraw);
            this.groupBox3.Controls.Add(this.aioGpuMod);
            this.groupBox3.Controls.Add(this.GPUModel);
            this.groupBox3.Controls.Add(this.GPUVRAM);
            this.groupBox3.Controls.Add(this.aioGpuV);
            this.groupBox3.Location = new System.Drawing.Point(343, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 219);
            this.groupBox3.TabIndex = 116;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPU Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aioMbPD);
            this.groupBox2.Controls.Add(this.aioMbMan);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.aioMbMod);
            this.groupBox2.Controls.Add(this.mbModel);
            this.groupBox2.Controls.Add(this.aioMbSock);
            this.groupBox2.Controls.Add(this.mbSocket);
            this.groupBox2.Controls.Add(this.mbPowerDraw);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(343, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 187);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motherboard Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aioCpuPD);
            this.groupBox1.Controls.Add(this.aioCpuMan);
            this.groupBox1.Controls.Add(this.aioCpuManufacturer);
            this.groupBox1.Controls.Add(this.aioCpuMod);
            this.groupBox1.Controls.Add(this.aioCpuModel);
            this.groupBox1.Controls.Add(this.aioCpuCS);
            this.groupBox1.Controls.Add(this.aioCpuClockSpeed);
            this.groupBox1.Controls.Add(this.aioCpuSock);
            this.groupBox1.Controls.Add(this.aioCpuSocket);
            this.groupBox1.Controls.Add(this.aioCpuPowerDraw);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(35, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 219);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Information";
            // 
            // InsertAllInOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 565);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aioNumOfFans);
            this.Controls.Add(this.aioNumFans);
            this.Controls.Add(this.aioManufacturer);
            this.Controls.Add(this.aioMan);
            this.Controls.Add(this.aioScreenX);
            this.Controls.Add(this.aioScreenY);
            this.Controls.Add(this.aioScreenYSize);
            this.Controls.Add(this.createAllInOneButton);
            this.Controls.Add(this.aioScreenXSize);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertAllInOne";
            this.Text = "Create All In One";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAllInOneButton;
        private System.Windows.Forms.Label aioScreenXSize;
        private System.Windows.Forms.Label aioScreenYSize;
        private System.Windows.Forms.TextBox aioScreenY;
        private System.Windows.Forms.TextBox aioScreenX;
        private System.Windows.Forms.Label GPUPowerDraw;
        private System.Windows.Forms.TextBox aioGpuPD;
        private System.Windows.Forms.Label GPUVRAM;
        private System.Windows.Forms.TextBox aioGpuV;
        private System.Windows.Forms.Label GPUModel;
        private System.Windows.Forms.TextBox aioGpuMod;
        private System.Windows.Forms.Label GPUManufacturer;
        private System.Windows.Forms.TextBox aioGpuMan;
        private System.Windows.Forms.Label mbPowerDraw;
        private System.Windows.Forms.TextBox aioMbPD;
        private System.Windows.Forms.Label mbSocket;
        private System.Windows.Forms.TextBox aioMbSock;
        private System.Windows.Forms.Label mbModel;
        private System.Windows.Forms.TextBox aioMbMod;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox aioMbMan;
        private System.Windows.Forms.Label aioCpuPowerDraw;
        private System.Windows.Forms.TextBox aioCpuPD;
        private System.Windows.Forms.Label aioCpuSocket;
        private System.Windows.Forms.TextBox aioCpuSock;
        private System.Windows.Forms.Label aioCpuClockSpeed;
        private System.Windows.Forms.TextBox aioCpuCS;
        private System.Windows.Forms.Label aioCpuModel;
        private System.Windows.Forms.TextBox aioCpuMod;
        private System.Windows.Forms.Label aioCpuManufacturer;
        private System.Windows.Forms.TextBox aioCpuMan;
        private System.Windows.Forms.Label aioNumOfFans;
        private System.Windows.Forms.TextBox aioNumFans;
        private System.Windows.Forms.Label aioManufacturer;
        private System.Windows.Forms.TextBox aioMan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}