// Stustent ID: 5436270
// Program 2 
// CIS-200-75
// Due 10/27/2023

// Class w form for inserting a tower

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Start
{
    public partial class InsertTower : Form
    {
        private ErrorProvider inputErrorProvider;
        public InsertTower()
        {
            InitializeComponent();
            inputErrorProvider = new ErrorProvider();
        }

        // validating event for strings
        // ensures user entered something
        private void stringTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                // set error
                inputErrorProvider.SetError((TextBox)sender, "Cannot be empty.");

                // tell Visual Studio validation vailed
                e.Cancel = true;
            }
        }


        // validating event for int text boxes
        // ensure user entered an integer
        private void intTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(((TextBox)sender).Text, out int input))
            {
                // set error
                inputErrorProvider.SetError((TextBox)sender, "Enter an integer.");

                // tell Visual Studio validation vailed
                e.Cancel = true;
            }
        }

        // validating event for string combo boxes
        // ensures user selected something
        private void stringComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedItem == null)
            {
                // set error
                inputErrorProvider.SetError((ComboBox)sender, "Cannot be empty.");

                // tell Visual Studio validation vailed
                e.Cancel = true;
            }
        }

        // validated event for string text boxes
        // clears error for valid input
        private void stringTextBox_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
            {
                // clears error from text box
                inputErrorProvider.SetError(((TextBox)sender), "");
            }
        }

        // validated event for integer text boxes
        // clears error for valid input
        private void intTextBox_Validated(object sender, EventArgs e)
        {
            if (int.TryParse(((TextBox)sender).Text, out int input))
            {
                // clears error from text box
                inputErrorProvider.SetError(((TextBox)sender), "");
            }
        }

        // validated event for string combo boxes
        // clears error for valid input
        private void stringComboBox_Validated(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedItem != null)
            {
                // clears error from combo box
                inputErrorProvider.SetError(((ComboBox)sender), "");
            }
        }

        // property for new tower created by user
        internal Tower NewTower { get; set; }

        // event handler for when Create button is clicked
        private void createTowerButton_Click(object sender, EventArgs e)
        {
            // ValidateChildren grabs Validation event for every child class
            // returns true if ALL children could be validated
            if (ValidateChildren() == true)
            { 

                string manufacturer = towerMan.Text;
                int numOfFans = int.Parse(towerNumFans.Text);
                string paneltype = towerPanelType.Text;

                string cpuManufacturer = towerCpuMan.Text;
                string cpuModel = towerMod.Text;
                int cpuClockspeed = int.Parse(towerCpuCS.Text);
                string cpuSocket = towerCpuSock.Text;
                int cpuPowerDraw = int.Parse(towerCpuPD.Text);

                string mbManufacturer = towerMbMan.Text;
                string mbModel = towerMbMod.Text;
                string mbSocket = towerMbSock.Text;
                int mbPowerDraw = int.Parse(towerMbPD.Text);

                string gpuManufacturer = towerGpuMan.Text;
                string gpuModel = towerGpuMod.Text;
                int gpuVram = int.Parse(towerGpuV.Text);
                int gpuPowerDraw = int.Parse(towerGpuPD.Text);

                // create CPU, Motherboard, GPU, Tower objects
                CPU cpu = new CPU(cpuManufacturer, cpuModel, cpuClockspeed, cpuSocket, cpuPowerDraw);
                Motherboard motherboard = new Motherboard(mbManufacturer, mbModel, mbSocket, mbPowerDraw);
                GPU gpu = new GPU(gpuManufacturer, gpuModel, gpuVram, gpuPowerDraw);

                Tower newTower = new Tower(manufacturer, cpu, gpu, motherboard, numOfFans, paneltype);

                NewTower = newTower;

                // set dialog result and close form
                this.DialogResult = DialogResult.OK;
                // close form but keep form in memory
                Hide();
            }
        }


    }
}
