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
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            if (radioBtnMass.Checked)
            {
                Mass mass = new Mass();
                if (radioBtnArrayV.Checked)
                {
                    try
                    {
                        txtIspis.Text = mass.ConvertArray(txtUnos.Text).ToString();
                        txtIspis.Enabled = false;

                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        txtIspis.Text = mass.Convert(Double.Parse(txtUnos.Text)).ToString();
                        txtIspis.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (radioBtnLength.Checked)
            {
                Length length = new Length();
                if (radioBtnArrayV.Checked)
                {
                    try
                    {
                        txtIspis.Text = length.ConvertArray(txtUnos.Text).ToString();
                        txtIspis.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        txtIspis.Text = length.Convert(Double.Parse(txtUnos.Text)).ToString();
                        txtIspis.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (radioBtnMoney.Checked)
            {
                Money money = new Money();
                if (radioBtnArrayV.Checked)
                {
                    try
                    {
                        txtIspis.Text = money.ConvertArray(txtUnos.Text).ToString();
                        txtIspis.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        txtIspis.Text = money.Convert(Double.Parse(txtUnos.Text)).ToString();
                        txtIspis.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (radioBtnTime.Checked)
            {
                Time time = new Time();
                try
                {
                    if (radioBtnHours.Checked)
                    {
                        txtIspis.Text = time.ConvertHours(Double.Parse(txtUnos.Text)).ToString();
                        txtIspis.Enabled = false;
                    }
                    else if (radioBtnMinutes.Checked)
                    {
                        txtIspis.Text = time.ConvertMinutes(Double.Parse(txtUnos.Text)).ToString();
                        txtIspis.Enabled = false;
                    }
                    else if (radioBtnSeconds.Checked)
                    {
                        txtIspis.Text = time.ConvertSeconds(Double.Parse(txtUnos.Text)).ToString();
                        txtIspis.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioBtnCustomMoney.Checked)
            {
                CustomMoney customMoney = new CustomMoney();
                try
                {
                    txtIspis.Text = customMoney.ConvertCustomMoney(txtUnos.Text).ToString();
                    txtIspis.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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