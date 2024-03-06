using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                double unosKonvert = int.Parse(txtUnos.Text) / 2.54;

                txtIspis.Text = unosKonvert.ToString();

            }
            else if(radioBtnLength.Checked) 
            {
                double unosKonvert = int.Parse(txtUnos.Text) / 2.2046;

                txtIspis.Text = unosKonvert.ToString();   
            }
            
        }

        private void radioBtnLength_CheckedChanged(object sender, EventArgs e)
        {
            lblUnos.Text = "Unos feet:";
            lblIspis.Text = "Ispis m:";
            txtUnos.Text = "";
            txtIspis.Text = "";
        }

        private void radioBtnMass_CheckedChanged(object sender, EventArgs e)
        {
            lblUnos.Text = "Unos pounds:";
            lblIspis.Text = "Ispis kg:";
            txtUnos.Text = "";
            txtIspis.Text = "";
        }
    }
}
