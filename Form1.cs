using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCalculate : Form
    {
        public frmCalculate()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare the variables to be used here. As these are to be decimals, decimal is used here. larger numbers require float. 
            decimal volts;
            decimal amps;
            decimal resistance;
            decimal result;

            //Read in the values of the text boxes. If there is a null, the value should be set to zero.

            try
            {
                volts = decimal.Parse(txtVolts.Text);
            }
            catch
            {
                volts = 0;
            }

            try
            {
                amps = decimal.Parse(txtAmps.Text);
            }
            catch
            {
                amps = 0;
            }

            try
            {
                resistance = decimal.Parse(txtResistance.Text);
            }
            catch
            {
                resistance = 0;
            }

            if (rdoVoltage.Checked == true)
            {
                result = amps * resistance;
                lblUnit.Text = "V";
                txtResult.Text = result.ToString();
            }
            else if (rdoCurrent.Checked == true)
            {
                result = volts / resistance;
                lblUnit.Text = "A";
                txtResult.Text = result.ToString();
            }
            else if (rdoResistance.Checked == true)
            {
                result = (volts / amps) * 1000;
                lblUnit.Text = "Ω";
                txtResult.Text = result.ToString();
            }


            //Now to apply the control logic. This is to provide the correct calculation based upon the selection made.
            //This is to be achieved using a nested if, however a more complex statement would be more efficient using a switch


        }

        private void rdoVoltage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVoltage.Checked == true)
            {
                txtVolts.Enabled = false;
            }
            else
            {
                txtVolts.Enabled = true;
            }
        }

        private void rdoCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCurrent.Checked == true)
            {
                txtAmps.Enabled = false;
            }
            else
            {
                txtAmps.Enabled = true;
            }
        }

        private void rdoResistance_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoResistance.Checked == true)
            {
                txtResistance.Enabled = false;
            }
            else
            {
                txtResistance.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset all the inputs to accept a new calculation

            txtAmps.Text = "";
            txtResistance.Text = "";
            txtResult.Text = "";
            txtVolts.Text = "";
            rdoCurrent.Checked = false;
            rdoResistance.Checked = false;
            rdoVoltage.Checked = false;
        }
    }
}
