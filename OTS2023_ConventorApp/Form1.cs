using OTS2023_ConventorApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(radioBtnMass.Checked)
            {
                Mass mass = new Mass();
                txtIspis.Text = mass.Convert(int.Parse(txtUnos.Text)).ToString();
                txtIspis.Enabled = false;

            }
            else if(radioBtnLength.Checked) 
            {
                double unosKonvert = int.Parse(txtUnos.Text) / 2.2046;

                Length length = new Length();
                txtIspis.Text = length.Convert(int.Parse(txtUnos.Text)).ToString();
                txtIspis.Enabled = false;

            }

        }

        private void radioBtnLength_CheckedChanged(object sender, EventArgs e)
        {
            gbxTime.Visible = false;
            gbxSegment.Visible = true;
            lblUnos.Text = "Unos feet:";
            lblIspis.Text = "Ispis m:";
            txtUnos.Text = "";
            txtIspis.Text = "";
        }

        private void radioBtnMass_CheckedChanged(object sender, EventArgs e)
        {
            gbxTime.Visible = false;
            gbxSegment.Visible = true;
            lblUnos.Text = "Unos pounds:";
            lblIspis.Text = "Ispis kg:";
            txtUnos.Text = "";
            txtIspis.Text = "";
        }

        private void radioBtnMoney_CheckedChanged(object sender, EventArgs e)
        {
            gbxTime.Visible = false;
            gbxSegment.Visible = true;
            lblUnos.Text = "eur";
            lblIspis.Text = "rsd";
            txtUnos.Text = "";
            txtIspis.Text = "";
        }

        private void radioBtnTime_CheckedChanged(object sender, EventArgs e)
        {
            lblUnos.Text = "days";
            gbxTime.Visible = true;
            gbxSegment.Visible = false;
            if (radioBtnHours.Checked)
            {
                lblIspis.Text = "hours";
            }
            else if (radioBtnMinutes.Checked)
            {
                lblIspis.Text = "minutes";
            }
            else
            {
                lblIspis.Text = "seconds";
            }
            txtUnos.Text = "";
            txtIspis.Text = "";
        }

        private void radioBtnCustomMoney_CheckedChanged(object sender, EventArgs e)
        {
            gbxTime.Visible = false;
            gbxSegment.Visible = false;
            lblUnos.Text = "custom expression";
            lblIspis.Text = "result";
            txtUnos.Text = "";
            txtIspis.Text = "";
        }

        
    }
}
