namespace WindowsFormsApplication1
{
    partial class frmCalculate
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
            this.rdoVoltage = new System.Windows.Forms.RadioButton();
            this.rdoCurrent = new System.Windows.Forms.RadioButton();
            this.rdoResistance = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpValues = new System.Windows.Forms.GroupBox();
            this.txtAmps = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtResistance = new System.Windows.Forms.TextBox();
            this.txtVolts = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResistance = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblVolts = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            this.grpValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoVoltage
            // 
            this.rdoVoltage.AutoSize = true;
            this.rdoVoltage.Location = new System.Drawing.Point(6, 23);
            this.rdoVoltage.Name = "rdoVoltage";
            this.rdoVoltage.Size = new System.Drawing.Size(61, 17);
            this.rdoVoltage.TabIndex = 0;
            this.rdoVoltage.Text = "Voltage";
            this.rdoVoltage.UseVisualStyleBackColor = true;
            this.rdoVoltage.CheckedChanged += new System.EventHandler(this.rdoVoltage_CheckedChanged);
            // 
            // rdoCurrent
            // 
            this.rdoCurrent.AutoSize = true;
            this.rdoCurrent.Location = new System.Drawing.Point(6, 46);
            this.rdoCurrent.Name = "rdoCurrent";
            this.rdoCurrent.Size = new System.Drawing.Size(59, 17);
            this.rdoCurrent.TabIndex = 0;
            this.rdoCurrent.Text = "Current";
            this.rdoCurrent.UseVisualStyleBackColor = true;
            this.rdoCurrent.CheckedChanged += new System.EventHandler(this.rdoCurrent_CheckedChanged);
            // 
            // rdoResistance
            // 
            this.rdoResistance.AutoSize = true;
            this.rdoResistance.Location = new System.Drawing.Point(6, 69);
            this.rdoResistance.Name = "rdoResistance";
            this.rdoResistance.Size = new System.Drawing.Size(78, 17);
            this.rdoResistance.TabIndex = 0;
            this.rdoResistance.Text = "Resistance";
            this.rdoResistance.UseVisualStyleBackColor = true;
            this.rdoResistance.CheckedChanged += new System.EventHandler(this.rdoResistance_CheckedChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.rdoVoltage);
            this.grpOptions.Controls.Add(this.rdoResistance);
            this.grpOptions.Controls.Add(this.rdoCurrent);
            this.grpOptions.Location = new System.Drawing.Point(292, 12);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(137, 100);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Calcuations";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(292, 119);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(67, 48);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpValues
            // 
            this.grpValues.Controls.Add(this.txtAmps);
            this.grpValues.Controls.Add(this.txtResult);
            this.grpValues.Controls.Add(this.txtResistance);
            this.grpValues.Controls.Add(this.txtVolts);
            this.grpValues.Controls.Add(this.lblResult);
            this.grpValues.Controls.Add(this.lblResistance);
            this.grpValues.Controls.Add(this.lblCurrent);
            this.grpValues.Controls.Add(this.lblUnit);
            this.grpValues.Controls.Add(this.lblO);
            this.grpValues.Controls.Add(this.lblA);
            this.grpValues.Controls.Add(this.lblV);
            this.grpValues.Controls.Add(this.lblVolts);
            this.grpValues.Location = new System.Drawing.Point(23, 12);
            this.grpValues.Name = "grpValues";
            this.grpValues.Size = new System.Drawing.Size(263, 155);
            this.grpValues.TabIndex = 3;
            this.grpValues.TabStop = false;
            this.grpValues.Text = "Values";
            // 
            // txtAmps
            // 
            this.txtAmps.Location = new System.Drawing.Point(72, 61);
            this.txtAmps.Name = "txtAmps";
            this.txtAmps.Size = new System.Drawing.Size(100, 20);
            this.txtAmps.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(72, 122);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 1;
            // 
            // txtResistance
            // 
            this.txtResistance.Location = new System.Drawing.Point(72, 87);
            this.txtResistance.Name = "txtResistance";
            this.txtResistance.Size = new System.Drawing.Size(100, 20);
            this.txtResistance.TabIndex = 1;
            // 
            // txtVolts
            // 
            this.txtVolts.AcceptsReturn = true;
            this.txtVolts.Location = new System.Drawing.Point(72, 35);
            this.txtVolts.Name = "txtVolts";
            this.txtVolts.Size = new System.Drawing.Size(100, 20);
            this.txtVolts.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(6, 125);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // lblResistance
            // 
            this.lblResistance.AutoSize = true;
            this.lblResistance.Location = new System.Drawing.Point(6, 87);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(60, 13);
            this.lblResistance.TabIndex = 0;
            this.lblResistance.Text = "Resistance";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(6, 64);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(41, 13);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(178, 125);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(10, 13);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "-";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(178, 87);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(16, 13);
            this.lblO.TabIndex = 0;
            this.lblO.Text = "Ω";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(178, 64);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(178, 42);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(14, 13);
            this.lblV.TabIndex = 0;
            this.lblV.Text = "V";
            // 
            // lblVolts
            // 
            this.lblVolts.AutoSize = true;
            this.lblVolts.Location = new System.Drawing.Point(4, 42);
            this.lblVolts.Name = "lblVolts";
            this.lblVolts.Size = new System.Drawing.Size(43, 13);
            this.lblVolts.TabIndex = 0;
            this.lblVolts.Text = "Voltage";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(362, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 48);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 179);
            this.Controls.Add(this.grpValues);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpOptions);
            this.Name = "frmCalculate";
            this.Text = "Circuit Calculator";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpValues.ResumeLayout(false);
            this.grpValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoVoltage;
        private System.Windows.Forms.RadioButton rdoCurrent;
        private System.Windows.Forms.RadioButton rdoResistance;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpValues;
        private System.Windows.Forms.TextBox txtAmps;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtResistance;
        private System.Windows.Forms.TextBox txtVolts;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResistance;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblVolts;
        private System.Windows.Forms.Button btnReset;
    }
}

