namespace OTS2023_ConventorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.radioBtnMass = new System.Windows.Forms.RadioButton();
            this.radioBtnLength = new System.Windows.Forms.RadioButton();
            this.lblUnos = new System.Windows.Forms.Label();
            this.lblIspis = new System.Windows.Forms.Label();
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // radioBtnMass
            // 
            this.radioBtnMass.AutoSize = true;
            this.radioBtnMass.Checked = true;
            this.radioBtnMass.Location = new System.Drawing.Point(17, 19);
            this.radioBtnMass.Name = "radioBtnMass";
            this.radioBtnMass.Size = new System.Drawing.Size(50, 17);
            this.radioBtnMass.TabIndex = 1;
            this.radioBtnMass.TabStop = true;
            this.radioBtnMass.Text = "Mass";
            this.radioBtnMass.UseVisualStyleBackColor = true;
            this.radioBtnMass.CheckedChanged += new System.EventHandler(this.radioBtnMass_CheckedChanged);
            // 
            // radioBtnLength
            // 
            this.radioBtnLength.AutoSize = true;
            this.radioBtnLength.Location = new System.Drawing.Point(17, 42);
            this.radioBtnLength.Name = "radioBtnLength";
            this.radioBtnLength.Size = new System.Drawing.Size(58, 17);
            this.radioBtnLength.TabIndex = 2;
            this.radioBtnLength.Text = "Length";
            this.radioBtnLength.UseVisualStyleBackColor = true;
            this.radioBtnLength.CheckedChanged += new System.EventHandler(this.radioBtnLength_CheckedChanged);
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(34, 156);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(73, 13);
            this.lblUnos.TabIndex = 3;
            this.lblUnos.Text = "Unos pounds:";
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Location = new System.Drawing.Point(34, 193);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(46, 13);
            this.lblIspis.TabIndex = 4;
            this.lblIspis.Text = "Ispis kg:";
            // 
            // txtUnos
            // 
            this.txtUnos.Location = new System.Drawing.Point(121, 153);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(193, 20);
            this.txtUnos.TabIndex = 5;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(121, 193);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(193, 20);
            this.txtIspis.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(215, 259);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(161, 51);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnLength);
            this.groupBox1.Controls.Add(this.radioBtnMass);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtUnos);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.lblUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton radioBtnMass;
        private System.Windows.Forms.RadioButton radioBtnLength;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.Label lblIspis;
        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

