// Stustent ID: 5436270
// Program 2 
// CIS-200-75
// Due 10/27/2023

// Class w form for inserting an all in one

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
    public partial class InsertAllInOne : Form
    {
        private ErrorProvider inputErrorProvider;

        public InsertAllInOne()
        {
            InitializeComponent();
            inputErrorProvider = new ErrorProvider();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        // validating event for integers
        // ensures user entered an integer
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

        // property for new AllInOne created by user
        internal AllInOne NewAllInOne { get; set; }

        // event handler for when Create button is clicked
        private void createAllInOneButton_Click(object sender, EventArgs e)
        {
            // ValidateChildren grabs Validation event for every child class
            // returns true if ALL children could be validated
            if (ValidateChildren() == true)
            {

                string manufacturer = aioMan.Text;
                int numOfFans = int.Parse(aioNumFans.Text);
                int screenXSize = int.Parse(aioScreenX.Text);
                int screenYSize = int.Parse(aioScreenY.Text);

                string cpuManufacturer = aioCpuMan.Text;
                string cpuModel = aioCpuMod.Text;
                int cpuClockSpeed = int.Parse(aioCpuCS.Text);
                string cpuSocket = aioCpuSock.Text;
                int cpuPowerDraw = int.Parse(aioCpuPD.Text);

                string mbManufacturer = aioMbMan.Text;
                string mbModel = aioMbMod.Text;
                string mbSocket = aioMbSock.Text;
                int mbPowerDraw = int.Parse(aioMbPD.Text);

                string gpuManufacturer = aioGpuMan.Text;
                string gpuModel = aioGpuMod.Text;
                int gpuVram = int.Parse(aioGpuV.Text);
                int gpuPowerDraw = int.Parse(aioGpuPD.Text);

                // create CPU, Motherboard, GPU, AllInOne objects
                CPU cpu = new CPU(cpuManufacturer, cpuModel, cpuClockSpeed, cpuSocket, cpuPowerDraw);
                Motherboard motherboard = new Motherboard(mbManufacturer, mbModel, mbSocket, mbPowerDraw);
                GPU gpu = new GPU(gpuManufacturer, gpuModel, gpuVram, gpuPowerDraw);

                AllInOne newAllInOne = new AllInOne(manufacturer, cpu, gpu, motherboard, numOfFans, screenXSize, screenYSize);

                NewAllInOne = newAllInOne;

                // set dialog result
                this.DialogResult = DialogResult.OK;
                // close form but keep form in memory
                Hide();
            }
        }
    }
}
