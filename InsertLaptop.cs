// Stustent ID: 5436270
// Program 2 
// CIS-200-75
// Due 10/27/2023

// Class w form for inserting a laptop

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
    public partial class InsertLaptop : Form
    {

        private ErrorProvider inputErrorProvider;

        public InsertLaptop()
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

        // property for new Laptop created by user
        internal Laptop NewLaptop { get; set; }

        // event handler for when Create button is clicked
        private void createLaptopButton_Click(object sender, EventArgs e)
        {
            // ValidateChildren grabs Validation event for every child class
            // returns true if ALL children could be validated
            if (ValidateChildren() == true)
            {

                string manufacturer = laptopMan.Text;
                string model = laptopMod.Text;
                int fixedTdp = int.Parse(laptopFixedTdp.Text);


                string cpuManufacturer = laptopCpuMan.Text;
                string cpuModel = laptopCpuMod.Text;
                int cpuClockSpeed = int.Parse(laptopCpuCS.Text);
                string cpuSocket = laptopCpuSock.Text;
                int cpuPowerDraw = int.Parse(laptopCpuPD.Text);

                // create CPU, Motherboard, GPU, Laptop objects
                CPU cpu = new CPU(cpuManufacturer, cpuModel, cpuClockSpeed, cpuSocket, cpuPowerDraw);

                Laptop newLaptop = new Laptop(manufacturer, model, cpu, fixedTdp);

                NewLaptop = newLaptop;

                // set dialog result and close form
                this.DialogResult = DialogResult.OK;
                // close form but keep form in memory
                Hide();
            }
        }
    }
}
