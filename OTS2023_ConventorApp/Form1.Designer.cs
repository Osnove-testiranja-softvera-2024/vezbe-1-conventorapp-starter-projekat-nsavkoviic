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
            this.gbxConverter = new System.Windows.Forms.GroupBox();
            this.radioBtnCustomMoney = new System.Windows.Forms.RadioButton();
            this.radioBtnTime = new System.Windows.Forms.RadioButton();
            this.radioBtnMoney = new System.Windows.Forms.RadioButton();
            this.gbxTime = new System.Windows.Forms.GroupBox();
            this.radioBtnSeconds = new System.Windows.Forms.RadioButton();
            this.radioBtnMinutes = new System.Windows.Forms.RadioButton();
            this.radioBtnHours = new System.Windows.Forms.RadioButton();
            this.gbxSegment = new System.Windows.Forms.GroupBox();
            this.radioBtnArrayV = new System.Windows.Forms.RadioButton();
            this.radioBtnSingleV = new System.Windows.Forms.RadioButton();
            this.gbxConverter.SuspendLayout();
            this.gbxTime.SuspendLayout();
            this.gbxSegment.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // radioBtnMass
            // 
            this.radioBtnMass.AutoSize = true;
            this.radioBtnMass.Checked = true;
            this.radioBtnMass.Location = new System.Drawing.Point(23, 23);
            this.radioBtnMass.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnMass.Name = "radioBtnMass";
            this.radioBtnMass.Size = new System.Drawing.Size(61, 20);
            this.radioBtnMass.TabIndex = 1;
            this.radioBtnMass.TabStop = true;
            this.radioBtnMass.Text = "Mass";
            this.radioBtnMass.UseVisualStyleBackColor = true;
            this.radioBtnMass.CheckedChanged += new System.EventHandler(this.radioBtnMass_CheckedChanged);
            // 
            // radioBtnLength
            // 
            this.radioBtnLength.AutoSize = true;
            this.radioBtnLength.Location = new System.Drawing.Point(23, 52);
            this.radioBtnLength.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnLength.Name = "radioBtnLength";
            this.radioBtnLength.Size = new System.Drawing.Size(68, 20);
            this.radioBtnLength.TabIndex = 2;
            this.radioBtnLength.Text = "Length";
            this.radioBtnLength.UseVisualStyleBackColor = true;
            this.radioBtnLength.CheckedChanged += new System.EventHandler(this.radioBtnLength_CheckedChanged);
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(23, 218);
            this.lblUnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(90, 16);
            this.lblUnos.TabIndex = 3;
            this.lblUnos.Text = "Unos pounds:";
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Location = new System.Drawing.Point(23, 264);
            this.lblIspis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(56, 16);
            this.lblIspis.TabIndex = 4;
            this.lblIspis.Text = "Ispis kg:";
            // 
            // txtUnos
            // 
            this.txtUnos.Location = new System.Drawing.Point(139, 214);
            this.txtUnos.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(256, 22);
            this.txtUnos.TabIndex = 5;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(139, 264);
            this.txtIspis.Margin = new System.Windows.Forms.Padding(4);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(256, 22);
            this.txtIspis.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(314, 396);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(215, 63);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // gbxConverter
            // 
            this.gbxConverter.Controls.Add(this.radioBtnCustomMoney);
            this.gbxConverter.Controls.Add(this.radioBtnTime);
            this.gbxConverter.Controls.Add(this.radioBtnMoney);
            this.gbxConverter.Controls.Add(this.radioBtnLength);
            this.gbxConverter.Controls.Add(this.radioBtnMass);
            this.gbxConverter.Location = new System.Drawing.Point(13, 33);
            this.gbxConverter.Margin = new System.Windows.Forms.Padding(4);
            this.gbxConverter.Name = "gbxConverter";
            this.gbxConverter.Padding = new System.Windows.Forms.Padding(4);
            this.gbxConverter.Size = new System.Drawing.Size(233, 130);
            this.gbxConverter.TabIndex = 8;
            this.gbxConverter.TabStop = false;
            this.gbxConverter.Text = "Converter type";
            // 
            // radioBtnCustomMoney
            // 
            this.radioBtnCustomMoney.AutoSize = true;
            this.radioBtnCustomMoney.Location = new System.Drawing.Point(54, 91);
            this.radioBtnCustomMoney.Name = "radioBtnCustomMoney";
            this.radioBtnCustomMoney.Size = new System.Drawing.Size(117, 20);
            this.radioBtnCustomMoney.TabIndex = 5;
            this.radioBtnCustomMoney.TabStop = true;
            this.radioBtnCustomMoney.Text = "Custom money";
            this.radioBtnCustomMoney.UseVisualStyleBackColor = true;
            this.radioBtnCustomMoney.CheckedChanged += new System.EventHandler(this.radioBtnCustomMoney_CheckedChanged);
            // 
            // radioBtnTime
            // 
            this.radioBtnTime.AutoSize = true;
            this.radioBtnTime.Location = new System.Drawing.Point(126, 52);
            this.radioBtnTime.Name = "radioBtnTime";
            this.radioBtnTime.Size = new System.Drawing.Size(59, 20);
            this.radioBtnTime.TabIndex = 4;
            this.radioBtnTime.TabStop = true;
            this.radioBtnTime.Text = "Time";
            this.radioBtnTime.UseVisualStyleBackColor = true;
            this.radioBtnTime.CheckedChanged += new System.EventHandler(this.radioBtnTime_CheckedChanged);
            // 
            // radioBtnMoney
            // 
            this.radioBtnMoney.AutoSize = true;
            this.radioBtnMoney.Location = new System.Drawing.Point(126, 23);
            this.radioBtnMoney.Name = "radioBtnMoney";
            this.radioBtnMoney.Size = new System.Drawing.Size(69, 20);
            this.radioBtnMoney.TabIndex = 3;
            this.radioBtnMoney.TabStop = true;
            this.radioBtnMoney.Text = "Money";
            this.radioBtnMoney.UseVisualStyleBackColor = true;
            this.radioBtnMoney.CheckedChanged += new System.EventHandler(this.radioBtnMoney_CheckedChanged);
            // 
            // gbxTime
            // 
            this.gbxTime.Controls.Add(this.radioBtnSeconds);
            this.gbxTime.Controls.Add(this.radioBtnMinutes);
            this.gbxTime.Controls.Add(this.radioBtnHours);
            this.gbxTime.Location = new System.Drawing.Point(262, 34);
            this.gbxTime.Name = "gbxTime";
            this.gbxTime.Size = new System.Drawing.Size(142, 129);
            this.gbxTime.TabIndex = 9;
            this.gbxTime.TabStop = false;
            this.gbxTime.Text = "Time output";
            this.gbxTime.Visible = false;
            // 
            // radioBtnSeconds
            // 
            this.radioBtnSeconds.AutoSize = true;
            this.radioBtnSeconds.Location = new System.Drawing.Point(6, 103);
            this.radioBtnSeconds.Name = "radioBtnSeconds";
            this.radioBtnSeconds.Size = new System.Drawing.Size(82, 20);
            this.radioBtnSeconds.TabIndex = 2;
            this.radioBtnSeconds.TabStop = true;
            this.radioBtnSeconds.Text = "Seconds";
            this.radioBtnSeconds.UseVisualStyleBackColor = true;
            // 
            // radioBtnMinutes
            // 
            this.radioBtnMinutes.AutoSize = true;
            this.radioBtnMinutes.Location = new System.Drawing.Point(6, 68);
            this.radioBtnMinutes.Name = "radioBtnMinutes";
            this.radioBtnMinutes.Size = new System.Drawing.Size(74, 20);
            this.radioBtnMinutes.TabIndex = 1;
            this.radioBtnMinutes.TabStop = true;
            this.radioBtnMinutes.Text = "Minutes";
            this.radioBtnMinutes.UseVisualStyleBackColor = true;
            // 
            // radioBtnHours
            // 
            this.radioBtnHours.AutoSize = true;
            this.radioBtnHours.Location = new System.Drawing.Point(6, 32);
            this.radioBtnHours.Name = "radioBtnHours";
            this.radioBtnHours.Size = new System.Drawing.Size(64, 20);
            this.radioBtnHours.TabIndex = 0;
            this.radioBtnHours.TabStop = true;
            this.radioBtnHours.Text = "Hours";
            this.radioBtnHours.UseVisualStyleBackColor = true;
            // 
            // gbxSegment
            // 
            this.gbxSegment.Controls.Add(this.radioBtnArrayV);
            this.gbxSegment.Controls.Add(this.radioBtnSingleV);
            this.gbxSegment.Location = new System.Drawing.Point(419, 34);
            this.gbxSegment.Name = "gbxSegment";
            this.gbxSegment.Size = new System.Drawing.Size(157, 129);
            this.gbxSegment.TabIndex = 10;
            this.gbxSegment.TabStop = false;
            this.gbxSegment.Text = "Segment Type";
            // 
            // radioBtnArrayV
            // 
            this.radioBtnArrayV.AutoSize = true;
            this.radioBtnArrayV.Location = new System.Drawing.Point(7, 68);
            this.radioBtnArrayV.Name = "radioBtnArrayV";
            this.radioBtnArrayV.Size = new System.Drawing.Size(117, 20);
            this.radioBtnArrayV.TabIndex = 1;
            this.radioBtnArrayV.Text = "Array of values";
            this.radioBtnArrayV.UseVisualStyleBackColor = true;
            // 
            // radioBtnSingleV
            // 
            this.radioBtnSingleV.AutoSize = true;
            this.radioBtnSingleV.Checked = true;
            this.radioBtnSingleV.Location = new System.Drawing.Point(7, 32);
            this.radioBtnSingleV.Name = "radioBtnSingleV";
            this.radioBtnSingleV.Size = new System.Drawing.Size(102, 20);
            this.radioBtnSingleV.TabIndex = 0;
            this.radioBtnSingleV.TabStop = true;
            this.radioBtnSingleV.Text = "Signle value";
            this.radioBtnSingleV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 492);
            this.Controls.Add(this.gbxSegment);
            this.Controls.Add(this.gbxTime);
            this.Controls.Add(this.gbxConverter);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtUnos);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.lblUnos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxConverter.ResumeLayout(false);
            this.gbxConverter.PerformLayout();
            this.gbxTime.ResumeLayout(false);
            this.gbxTime.PerformLayout();
            this.gbxSegment.ResumeLayout(false);
            this.gbxSegment.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxConverter;
        private System.Windows.Forms.GroupBox gbxTime;
        private System.Windows.Forms.GroupBox gbxSegment;
        private System.Windows.Forms.RadioButton radioBtnCustomMoney;
        private System.Windows.Forms.RadioButton radioBtnTime;
        private System.Windows.Forms.RadioButton radioBtnMoney;
        private System.Windows.Forms.RadioButton radioBtnSeconds;
        private System.Windows.Forms.RadioButton radioBtnMinutes;
        private System.Windows.Forms.RadioButton radioBtnHours;
        private System.Windows.Forms.RadioButton radioBtnArrayV;
        private System.Windows.Forms.RadioButton radioBtnSingleV;
    }
}

