namespace Prog2Start
{
    partial class computerViewForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allInOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.towerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerListView = new System.Windows.Forms.ListView();
            this.manufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tdp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailsButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laptopToolStripMenuItem,
            this.allInOneToolStripMenuItem,
            this.towerToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // laptopToolStripMenuItem
            // 
            this.laptopToolStripMenuItem.Name = "laptopToolStripMenuItem";
            this.laptopToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.laptopToolStripMenuItem.Text = "Laptop";
            this.laptopToolStripMenuItem.Click += new System.EventHandler(this.laptopToolStripMenuItem_Click);
            // 
            // allInOneToolStripMenuItem
            // 
            this.allInOneToolStripMenuItem.Name = "allInOneToolStripMenuItem";
            this.allInOneToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.allInOneToolStripMenuItem.Text = "All In One";
            this.allInOneToolStripMenuItem.Click += new System.EventHandler(this.allInOneToolStripMenuItem_Click);
            // 
            // towerToolStripMenuItem
            // 
            this.towerToolStripMenuItem.Name = "towerToolStripMenuItem";
            this.towerToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.towerToolStripMenuItem.Text = "Tower";
            this.towerToolStripMenuItem.Click += new System.EventHandler(this.towerToolStripMenuItem_Click);
            // 
            // computerListView
            // 
            this.computerListView.AllowColumnReorder = true;
            this.computerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.manufacturer,
            this.tdp,
            this.deviceType});
            this.computerListView.FullRowSelect = true;
            this.computerListView.GridLines = true;
            this.computerListView.HideSelection = false;
            this.computerListView.Location = new System.Drawing.Point(69, 48);
            this.computerListView.Name = "computerListView";
            this.computerListView.Size = new System.Drawing.Size(451, 300);
            this.computerListView.TabIndex = 1;
            this.computerListView.UseCompatibleStateImageBehavior = false;
            this.computerListView.View = System.Windows.Forms.View.Details;
            // 
            // manufacturer
            // 
            this.manufacturer.Text = "Manufacturer";
            this.manufacturer.Width = 120;
            // 
            // tdp
            // 
            this.tdp.Text = "TDP";
            this.tdp.Width = 80;
            // 
            // deviceType
            // 
            this.deviceType.Text = "DeviceType";
            this.deviceType.Width = 100;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(254, 365);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(97, 40);
            this.detailsButton.TabIndex = 2;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // computerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 417);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.computerListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "computerViewForm";
            this.Text = "User Computer View";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laptopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allInOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem towerToolStripMenuItem;
        private System.Windows.Forms.ListView computerListView;
        private System.Windows.Forms.ColumnHeader manufacturer;
        private System.Windows.Forms.ColumnHeader tdp;
        private System.Windows.Forms.ColumnHeader deviceType;
        private System.Windows.Forms.Button detailsButton;
    }
}

