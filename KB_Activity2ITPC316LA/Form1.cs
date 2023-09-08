using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace KB_Activity2ITPC316LA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the text from the employee name text box
            string employeeName = employeenametextbox.Text;

            if (!string.IsNullOrWhiteSpace(employeeName))
            {
                // Check if an employee type is selected
                if (Employeetypecombobox.SelectedItem != null)
                {
                    //Check days of work also
                    if(Daysofworkcombobox.SelectedItem != null)
                    {
                    SalaryCalculator sal = new SalaryCalculator();
                    string selectedEmployeeType = Employeetypecombobox.SelectedItem.ToString();
                    double ratePerDay = 0;
                    double sss = 0;
                    double medicare = 0;
                    double taxRate = 0;

                    // Determine the constants based on the selected employee type
                    switch (selectedEmployeeType)
                    {
                        case "Permanent":
                            ratePerDay = 850;
                            sss = 500;
                            medicare = 350;
                            taxRate = 0.25;
                            break;
                        case "Probationary":
                            ratePerDay = 550;
                            sss = 400;
                            medicare = 250;
                            taxRate = 0.15;
                            break;
                        case "Contractual":
                            ratePerDay = 350;
                            sss = 100;
                            medicare = 100;
                            taxRate = 0.15;
                            break;
                    }

                    // Get the selected number of days worked from the combobox
                    int numberOfDaysWorkPerWeek = Convert.ToInt32(Daysofworkcombobox.SelectedItem);


                    // Calculate using the Class Library
                    double grossPay = sal.CalculateGrossPay(numberOfDaysWorkPerWeek, ratePerDay);
                    double tax = sal.CalculateTax(grossPay, taxRate);
                    double deduction = sal.CalculateDeduction(sss, medicare, tax);
                    double netPay = sal.CalculateNetPay(grossPay, deduction);
                    string selectedworkdays = Daysofworkcombobox.SelectedItem.ToString();

                    // Format output values with spaces for thousands and decimal points
                    string formattedGrossPay = grossPay.ToString("N2");
                    string formattedDeduction = deduction.ToString("N2");
                    string formattedTax = tax.ToString("N2");
                    string formattedNetPay = netPay.ToString("N2");

                    // OUTPUT THE STUFF HERE
                    ComputedRichTextbox.AppendText("Employee Name: " + employeeName + Environment.NewLine);
                    ComputedRichTextbox.AppendText("Employee Type: " + selectedEmployeeType + Environment.NewLine);
                    ComputedRichTextbox.AppendText("Days of Work: " + selectedworkdays + Environment.NewLine);
                    ComputedRichTextbox.AppendText("Gross Pay: " + formattedGrossPay + Environment.NewLine);
                    ComputedRichTextbox.AppendText("Deduction: " + formattedDeduction + Environment.NewLine);
                    ComputedRichTextbox.AppendText("Tax: " + formattedTax + Environment.NewLine);
                    ComputedRichTextbox.AppendText("Net Pay: " + formattedNetPay + Environment.NewLine);
                    ComputedRichTextbox.AppendText("Date and Time: " + DateTime.Now + Environment.NewLine);

                    // Disable the submit button after clicking
                    submit.Enabled = false;
                    }

                     else
                    {
                        MessageBox.Show("Please select a work date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an employee type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter employee name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void clear_button_Click(object sender, EventArgs e)
        {
            // Clear output
            ComputedRichTextbox.Clear();
            employeenametextbox.Clear();
            Employeetypecombobox.SelectedItem = null;
            Daysofworkcombobox.SelectedItem = null;
            submit.Enabled = true;
        }
    }
}
