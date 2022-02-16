using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dealership;

namespace VehicleBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int year = DateTime.Now.Year + 1; year > 1920; year--)
                cmbYear.Items.Add(year);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle v = new Vehicle();

                v.Make = txtMake.Text;
                v.Model = txtModel.Text;
                v.Vin = txtVIN.Text;
                v.Year = Convert.ToInt32(cmbYear.SelectedItem);
                v.Doors = Convert.ToInt32(txtDoors.Text);
                v.Fuel = txtFuel.Text;

                MessageBox.Show("Vehicle Saved");

                lblDetails.Text = 
                    $"Year: {v.Year}\n" +
                    $"Make: {v.Make}\n" +
                    $"Model: {v.Model}\n" +
                    $"VIN: {v.Vin}\n" +
                    $"Doors: {v.Doors}\n" +
                    $"Fuel: {v.Fuel}\n";

                //clear previous input
                foreach (Control ctl in this.Controls)
                {
                    switch (ctl)
                    {
                        case TextBox txt:
                            txt.ResetText();
                            break;
                        case ComboBox cmb:
                            cmb.SelectedIndex = -1;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
