namespace Prog2Start
{
    partial class InsertTower
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
            this.towerMan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.towerNumFans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.towerPanelType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.towerCpuMan = new System.Windows.Forms.TextBox();
            this.towerCpuModel = new System.Windows.Forms.Label();
            this.towerMod = new System.Windows.Forms.TextBox();
            this.towerCpuClockSpeed = new System.Windows.Forms.Label();
            this.towerCpuCS = new System.Windows.Forms.TextBox();
            this.towerCpuSocket = new System.Windows.Forms.Label();
            this.towerCpuSock = new System.Windows.Forms.TextBox();
            this.towerCpuPowerDraw = new System.Windows.Forms.Label();
            this.towerCpuPD = new System.Windows.Forms.TextBox();
            this.towerMbPowerDraw = new System.Windows.Forms.Label();
            this.towerMbPD = new System.Windows.Forms.TextBox();
            this.towerMbSocket = new System.Windows.Forms.Label();
            this.mbModel = new System.Windows.Forms.Label();
            this.towerMbMod = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.towerMbMan = new System.Windows.Forms.TextBox();
            this.towerGpuPowerDraw = new System.Windows.Forms.Label();
            this.towerGpuPD = new System.Windows.Forms.TextBox();
            this.towerGpuVram = new System.Windows.Forms.Label();
            this.towerGpuV = new System.Windows.Forms.TextBox();
            this.towerGpuModel = new System.Windows.Forms.Label();
            this.towerGpuMod = new System.Windows.Forms.TextBox();
            this.towerGpuManufacturer = new System.Windows.Forms.Label();
            this.towerGpuMan = new System.Windows.Forms.TextBox();
            this.towerMbSock = new System.Windows.Forms.TextBox();
            this.createTowerButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // towerMan
            // 
            this.towerMan.Location = new System.Drawing.Point(159, 63);
            this.towerMan.Name = "towerMan";
            this.towerMan.Size = new System.Drawing.Size(136, 26);
            this.towerMan.TabIndex = 0;
            this.towerMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "# of Fans:";
            // 
            // towerNumFans
            // 
            this.towerNumFans.Location = new System.Drawing.Point(159, 103);
            this.towerNumFans.Name = "towerNumFans";
            this.towerNumFans.Size = new System.Drawing.Size(136, 26);
            this.towerNumFans.TabIndex = 2;
            this.towerNumFans.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.towerNumFans.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.towerNumFans.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Panel Type:";
            // 
            // towerPanelType
            // 
            this.towerPanelType.FormattingEnabled = true;
            this.towerPanelType.Items.AddRange(new object[] {
            "Glass",
            "Metal"});
            this.towerPanelType.Location = new System.Drawing.Point(159, 142);
            this.towerPanelType.Name = "towerPanelType";
            this.towerPanelType.Size = new System.Drawing.Size(136, 28);
            this.towerPanelType.TabIndex = 5;
            this.towerPanelType.TextUpdate += new System.EventHandler(this.stringComboBox_Validated);
            this.towerPanelType.Validating += new System.ComponentModel.CancelEventHandler(this.stringComboBox_Validating);
            this.towerPanelType.Validated += new System.EventHandler(this.stringComboBox_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Manufacturer:";
            // 
            // towerCpuMan
            // 
            this.towerCpuMan.Location = new System.Drawing.Point(127, 30);
            this.towerCpuMan.Name = "towerCpuMan";
            this.towerCpuMan.Size = new System.Drawing.Size(136, 26);
            this.towerCpuMan.TabIndex = 7;
            this.towerCpuMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerCpuMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerCpuMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // towerCpuModel
            // 
            this.towerCpuModel.AutoSize = true;
            this.towerCpuModel.Location = new System.Drawing.Point(15, 73);
            this.towerCpuModel.Name = "towerCpuModel";
            this.towerCpuModel.Size = new System.Drawing.Size(56, 20);
            this.towerCpuModel.TabIndex = 10;
            this.towerCpuModel.Text = "Model:";
            // 
            // towerMod
            // 
            this.towerMod.Location = new System.Drawing.Point(127, 67);
            this.towerMod.Name = "towerMod";
            this.towerMod.Size = new System.Drawing.Size(136, 26);
            this.towerMod.TabIndex = 9;
            this.towerMod.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerMod.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerMod.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // towerCpuClockSpeed
            // 
            this.towerCpuClockSpeed.AutoSize = true;
            this.towerCpuClockSpeed.Location = new System.Drawing.Point(15, 110);
            this.towerCpuClockSpeed.Name = "towerCpuClockSpeed";
            this.towerCpuClockSpeed.Size = new System.Drawing.Size(103, 20);
            this.towerCpuClockSpeed.TabIndex = 12;
            this.towerCpuClockSpeed.Text = "Clock Speed:";
            // 
            // towerCpuCS
            // 
            this.towerCpuCS.Location = new System.Drawing.Point(127, 104);
            this.towerCpuCS.Name = "towerCpuCS";
            this.towerCpuCS.Size = new System.Drawing.Size(136, 26);
            this.towerCpuCS.TabIndex = 11;
            this.towerCpuCS.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.towerCpuCS.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.towerCpuCS.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // towerCpuSocket
            // 
            this.towerCpuSocket.AutoSize = true;
            this.towerCpuSocket.Location = new System.Drawing.Point(15, 147);
            this.towerCpuSocket.Name = "towerCpuSocket";
            this.towerCpuSocket.Size = new System.Drawing.Size(63, 20);
            this.towerCpuSocket.TabIndex = 14;
            this.towerCpuSocket.Text = "Socket:";
            // 
            // towerCpuSock
            // 
            this.towerCpuSock.Location = new System.Drawing.Point(127, 141);
            this.towerCpuSock.Name = "towerCpuSock";
            this.towerCpuSock.Size = new System.Drawing.Size(136, 26);
            this.towerCpuSock.TabIndex = 13;
            this.towerCpuSock.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerCpuSock.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerCpuSock.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // towerCpuPowerDraw
            // 
            this.towerCpuPowerDraw.AutoSize = true;
            this.towerCpuPowerDraw.Location = new System.Drawing.Point(15, 184);
            this.towerCpuPowerDraw.Name = "towerCpuPowerDraw";
            this.towerCpuPowerDraw.Size = new System.Drawing.Size(98, 20);
            this.towerCpuPowerDraw.TabIndex = 16;
            this.towerCpuPowerDraw.Text = "Power Draw:";
            // 
            // towerCpuPD
            // 
            this.towerCpuPD.Location = new System.Drawing.Point(127, 178);
            this.towerCpuPD.Name = "towerCpuPD";
            this.towerCpuPD.Size = new System.Drawing.Size(136, 26);
            this.towerCpuPD.TabIndex = 15;
            this.towerCpuPD.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.towerCpuPD.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.towerCpuPD.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // towerMbPowerDraw
            // 
            this.towerMbPowerDraw.AutoSize = true;
            this.towerMbPowerDraw.Location = new System.Drawing.Point(11, 149);
            this.towerMbPowerDraw.Name = "towerMbPowerDraw";
            this.towerMbPowerDraw.Size = new System.Drawing.Size(98, 20);
            this.towerMbPowerDraw.TabIndex = 27;
            this.towerMbPowerDraw.Text = "Power Draw:";
            // 
            // towerMbPD
            // 
            this.towerMbPD.Location = new System.Drawing.Point(121, 143);
            this.towerMbPD.Name = "towerMbPD";
            this.towerMbPD.Size = new System.Drawing.Size(136, 26);
            this.towerMbPD.TabIndex = 26;
            this.towerMbPD.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.towerMbPD.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.towerMbPD.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // towerMbSocket
            // 
            this.towerMbSocket.AutoSize = true;
            this.towerMbSocket.Location = new System.Drawing.Point(11, 112);
            this.towerMbSocket.Name = "towerMbSocket";
            this.towerMbSocket.Size = new System.Drawing.Size(63, 20);
            this.towerMbSocket.TabIndex = 25;
            this.towerMbSocket.Text = "Socket:";
            // 
            // mbModel
            // 
            this.mbModel.AutoSize = true;
            this.mbModel.Location = new System.Drawing.Point(11, 69);
            this.mbModel.Name = "mbModel";
            this.mbModel.Size = new System.Drawing.Size(56, 20);
            this.mbModel.TabIndex = 21;
            this.mbModel.Text = "Model:";
            // 
            // towerMbMod
            // 
            this.towerMbMod.Location = new System.Drawing.Point(121, 63);
            this.towerMbMod.Name = "towerMbMod";
            this.towerMbMod.Size = new System.Drawing.Size(136, 26);
            this.towerMbMod.TabIndex = 20;
            this.towerMbMod.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerMbMod.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerMbMod.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Manufacturer:";
            // 
            // towerMbMan
            // 
            this.towerMbMan.Location = new System.Drawing.Point(121, 26);
            this.towerMbMan.Name = "towerMbMan";
            this.towerMbMan.Size = new System.Drawing.Size(136, 26);
            this.towerMbMan.TabIndex = 18;
            this.towerMbMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerMbMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerMbMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // towerGpuPowerDraw
            // 
            this.towerGpuPowerDraw.AutoSize = true;
            this.towerGpuPowerDraw.Location = new System.Drawing.Point(11, 167);
            this.towerGpuPowerDraw.Name = "towerGpuPowerDraw";
            this.towerGpuPowerDraw.Size = new System.Drawing.Size(98, 20);
            this.towerGpuPowerDraw.TabIndex = 38;
            this.towerGpuPowerDraw.Text = "Power Draw:";
            // 
            // towerGpuPD
            // 
            this.towerGpuPD.Location = new System.Drawing.Point(121, 160);
            this.towerGpuPD.Name = "towerGpuPD";
            this.towerGpuPD.Size = new System.Drawing.Size(136, 26);
            this.towerGpuPD.TabIndex = 37;
            this.towerGpuPD.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.towerGpuPD.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.towerGpuPD.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // towerGpuVram
            // 
            this.towerGpuVram.AutoSize = true;
            this.towerGpuVram.Location = new System.Drawing.Point(11, 127);
            this.towerGpuVram.Name = "towerGpuVram";
            this.towerGpuVram.Size = new System.Drawing.Size(60, 20);
            this.towerGpuVram.TabIndex = 34;
            this.towerGpuVram.Text = "VRAM:";
            // 
            // towerGpuV
            // 
            this.towerGpuV.Location = new System.Drawing.Point(121, 120);
            this.towerGpuV.Name = "towerGpuV";
            this.towerGpuV.Size = new System.Drawing.Size(136, 26);
            this.towerGpuV.TabIndex = 33;
            this.towerGpuV.TextChanged += new System.EventHandler(this.intTextBox_Validated);
            this.towerGpuV.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.towerGpuV.Validated += new System.EventHandler(this.intTextBox_Validated);
            // 
            // towerGpuModel
            // 
            this.towerGpuModel.AutoSize = true;
            this.towerGpuModel.Location = new System.Drawing.Point(11, 90);
            this.towerGpuModel.Name = "towerGpuModel";
            this.towerGpuModel.Size = new System.Drawing.Size(56, 20);
            this.towerGpuModel.TabIndex = 32;
            this.towerGpuModel.Text = "Model:";
            // 
            // towerGpuMod
            // 
            this.towerGpuMod.Location = new System.Drawing.Point(121, 83);
            this.towerGpuMod.Name = "towerGpuMod";
            this.towerGpuMod.Size = new System.Drawing.Size(136, 26);
            this.towerGpuMod.TabIndex = 31;
            this.towerGpuMod.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerGpuMod.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerGpuMod.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // towerGpuManufacturer
            // 
            this.towerGpuManufacturer.AutoSize = true;
            this.towerGpuManufacturer.Location = new System.Drawing.Point(11, 53);
            this.towerGpuManufacturer.Name = "towerGpuManufacturer";
            this.towerGpuManufacturer.Size = new System.Drawing.Size(108, 20);
            this.towerGpuManufacturer.TabIndex = 30;
            this.towerGpuManufacturer.Text = "Manufacturer:";
            // 
            // towerGpuMan
            // 
            this.towerGpuMan.Location = new System.Drawing.Point(121, 47);
            this.towerGpuMan.Name = "towerGpuMan";
            this.towerGpuMan.Size = new System.Drawing.Size(136, 26);
            this.towerGpuMan.TabIndex = 29;
            this.towerGpuMan.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerGpuMan.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerGpuMan.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // towerMbSock
            // 
            this.towerMbSock.Location = new System.Drawing.Point(121, 106);
            this.towerMbSock.Name = "towerMbSock";
            this.towerMbSock.Size = new System.Drawing.Size(136, 26);
            this.towerMbSock.TabIndex = 24;
            this.towerMbSock.TextChanged += new System.EventHandler(this.stringTextBox_Validated);
            this.towerMbSock.Validating += new System.ComponentModel.CancelEventHandler(this.stringTextBox_Validating);
            this.towerMbSock.Validated += new System.EventHandler(this.stringTextBox_Validated);
            // 
            // createTowerButton
            // 
            this.createTowerButton.Location = new System.Drawing.Point(262, 462);
            this.createTowerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createTowerButton.Name = "createTowerButton";
            this.createTowerButton.Size = new System.Drawing.Size(112, 35);
            this.createTowerButton.TabIndex = 39;
            this.createTowerButton.Text = "Create";
            this.createTowerButton.UseVisualStyleBackColor = true;
            this.createTowerButton.Click += new System.EventHandler(this.createTowerButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.towerCpuPD);
            this.groupBox1.Controls.Add(this.towerCpuMan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.towerMod);
            this.groupBox1.Controls.Add(this.towerCpuModel);
            this.groupBox1.Controls.Add(this.towerCpuCS);
            this.groupBox1.Controls.Add(this.towerCpuClockSpeed);
            this.groupBox1.Controls.Add(this.towerCpuSock);
            this.groupBox1.Controls.Add(this.towerCpuSocket);
            this.groupBox1.Controls.Add(this.towerCpuPowerDraw);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(32, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 219);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.towerMbPD);
            this.groupBox2.Controls.Add(this.towerMbMan);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.towerMbMod);
            this.groupBox2.Controls.Add(this.mbModel);
            this.groupBox2.Controls.Add(this.towerMbSock);
            this.groupBox2.Controls.Add(this.towerMbSocket);
            this.groupBox2.Controls.Add(this.towerMbPowerDraw);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(339, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 187);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motherboard Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.towerGpuPD);
            this.groupBox3.Controls.Add(this.towerGpuMan);
            this.groupBox3.Controls.Add(this.towerGpuManufacturer);
            this.groupBox3.Controls.Add(this.towerGpuMod);
            this.groupBox3.Controls.Add(this.towerGpuPowerDraw);
            this.groupBox3.Controls.Add(this.towerGpuModel);
            this.groupBox3.Controls.Add(this.towerGpuV);
            this.groupBox3.Controls.Add(this.towerGpuVram);
            this.groupBox3.Location = new System.Drawing.Point(339, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 219);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPU Information";
            // 
            // InsertTower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createTowerButton);
            this.Controls.Add(this.towerPanelType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.towerNumFans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.towerMan);
            this.Name = "InsertTower";
            this.Text = "Create Tower";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox towerMan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox towerNumFans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox towerPanelType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox towerCpuMan;
        private System.Windows.Forms.Label towerCpuModel;
        private System.Windows.Forms.TextBox towerMod;
        private System.Windows.Forms.Label towerCpuClockSpeed;
        private System.Windows.Forms.TextBox towerCpuCS;
        private System.Windows.Forms.Label towerCpuSocket;
        private System.Windows.Forms.TextBox towerCpuSock;
        private System.Windows.Forms.Label towerCpuPowerDraw;
        private System.Windows.Forms.TextBox towerCpuPD;
        private System.Windows.Forms.Label towerMbPowerDraw;
        private System.Windows.Forms.TextBox towerMbPD;
        private System.Windows.Forms.Label towerMbSocket;
        private System.Windows.Forms.Label mbModel;
        private System.Windows.Forms.TextBox towerMbMod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox towerMbMan;
        private System.Windows.Forms.Label towerGpuPowerDraw;
        private System.Windows.Forms.TextBox towerGpuPD;
        private System.Windows.Forms.Label towerGpuVram;
        private System.Windows.Forms.TextBox towerGpuV;
        private System.Windows.Forms.Label towerGpuModel;
        private System.Windows.Forms.TextBox towerGpuMod;
        private System.Windows.Forms.Label towerGpuManufacturer;
        private System.Windows.Forms.TextBox towerGpuMan;
        private System.Windows.Forms.TextBox towerMbSock;
        private System.Windows.Forms.Button createTowerButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}