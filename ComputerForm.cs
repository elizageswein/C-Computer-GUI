// Stustent ID: 5436270
// Program 2 
// CIS-200-75
// Due 10/27/2023

// Class w main Computer form

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
    public partial class computerViewForm : Form
    {
        public computerViewForm()
        {
            InitializeComponent();
        }

        // list to hold computer objects entered by user
        List<Computer> computers = new List<Computer>();

        // event handler for when Details button is clicked
        // displays selected computer's details to user
        private void detailsButton_Click(object sender, EventArgs e)
        {
            // ensure a computer is selected in computerListView
            if (computerListView.SelectedIndices.Count == 1)
            {
                // get selected computer's index
                int selectedIndex = computerListView.SelectedIndices[0];

                // display selected computer's details
                MessageBox.Show(computers[selectedIndex].ToString(), "Computer Details");
            }
            else
            {
                // display error message if user selected < or > 1 computer item
                MessageBox.Show("Invalid - Select ONE computer in list.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // event handler for when About menu item is clicked
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student ID: 5436270\nCourse Section: CIS 200-75");
        }
        
        // event handler for when Exit menu item is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close application
            Application.Exit();
        }

        // event handler for when Insert Laptop menu item is clicked
        private void laptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate class for laptop form
            InsertLaptop laptopForm = new InsertLaptop();

            // shows form to user
            // blocks interaction with first form until laptop form is closed
            laptopForm.ShowDialog();

            // if user clicked Create button
            if (laptopForm.ShowDialog() == DialogResult.OK)
            {
                // get laptop object created from laptop form
                Laptop newLaptop = laptopForm.NewLaptop;

                // add laptop object created to list of computers
                computers.Add(newLaptop);

                // array w strings of values to be inserted into computerListView
                // manufacturer, fixedTDP, device type
                string[] laptopListItem = {newLaptop.Manufacturer
                    , newLaptop.CalcTDP().ToString()
                    , "Laptop"};
                
                // ListViewItem object of string array
                ListViewItem laptopListViewItem = new ListViewItem(laptopListItem);

                // add ListViewItem to computer list and computerListView
                computerListView.Items.Add(laptopListViewItem);
            }
            else
            {
                MessageBox.Show("Input operation was cancelled.");
            }

            // dispose laptop form and reallocate form memory
            laptopForm.Dispose();
        }

        // event handler for when Insert Tower menu item is clicked
        private void towerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate class for tower form
            InsertTower towerForm = new InsertTower();

            // shows form to user
            // blocks interaction with first form until tower form is closed
            towerForm.ShowDialog();

            // if user clicked Create button
            if (towerForm.ShowDialog() == DialogResult.OK)
            {
                // get tower object created from tower form
                Tower newTower = towerForm.NewTower;

                // add tower object created to list of computers
                computers.Add(newTower);

                // array w strings of values to be inserted into computerListView
                // manufacturer, fixedTDP, device type
                string[] towerListItem = {newTower.Manufacturer
                    , newTower.CalcTDP().ToString()
                    , "Tower"};

                // ListViewItem object of string array
                ListViewItem towerListViewItem = new ListViewItem(towerListItem);

                // add ListViewItem to computer list and computerListView
                computerListView.Items.Add(towerListViewItem);
            }
            else
            {
                MessageBox.Show("Input operation was cancelled.");
            }

            // dispose tower form and reallocate form memory
            towerForm.Dispose();
        }

        // event handler for when Insert All In One menu item is clicked
        private void allInOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate class for allInOne form
            InsertAllInOne allInOneForm = new InsertAllInOne();

            // shows form to user
            // blocks interaction with first form until allInOne form is closed
            allInOneForm.ShowDialog();

            // if user clicked Create button
            if (allInOneForm.ShowDialog() == DialogResult.OK)
            {
                // get allInOne object created from allInOne form
                AllInOne newallInOne = allInOneForm.NewAllInOne;

                // add allInOne object created to list of computers
                computers.Add(newallInOne);

                // array w strings of values to be inserted into computerListView
                // manufacturer, fixedTDP, device type
                string[] allInOneListItem = {newallInOne.Manufacturer
                    , newallInOne.CalcTDP().ToString()
                    , "All In One"};

                // ListViewItem object of string array
                ListViewItem allInOneListViewItem = new ListViewItem(allInOneListItem);

                // add ListViewItem to computer list and computerListView
                computerListView.Items.Add(allInOneListViewItem);
            }
            else
            {
                MessageBox.Show("Input operation was cancelled.");
            }

            // dispose allInOne form and reallocate form memory
            allInOneForm.Dispose();
        }
    }
}
