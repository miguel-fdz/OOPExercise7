using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wmad.Party.Store;

namespace OOPEx7ReadWriteProps
{
    public partial class Form1 : Form
    {
        List<Balloon> balloons = new List<Balloon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Balloon myBalloon = new Balloon();

                myBalloon.Colour = txtColour.Text;
                myBalloon.Diameter = Convert.ToInt32(txtDiameter.Text);
                myBalloon.Height = Convert.ToInt32(txtHeight.Text);
                myBalloon.HasString = chkHastString.Checked;

                balloons.Add(myBalloon);

                MessageBox.Show($"Colour : {myBalloon.Colour} \n" +
                                $"Height: {myBalloon.Height} \n" +
                                $"Diameter: {myBalloon.Diameter}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
