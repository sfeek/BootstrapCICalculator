namespace Bootstrap_CI_Calculator
{
    partial class BootstrapCI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BootstrapCI));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDataA = new System.Windows.Forms.TextBox();
            this.txtCILow = new System.Windows.Forms.TextBox();
            this.lblCILow = new System.Windows.Forms.Label();
            this.txtCIHigh = new System.Windows.Forms.TextBox();
            this.lblCIHigh = new System.Windows.Forms.Label();
            this.txtMeanA = new System.Windows.Forms.TextBox();
            this.lblMeanA = new System.Windows.Forms.Label();
            this.lblDataA = new System.Windows.Forms.Label();
            this.txtDataB = new System.Windows.Forms.TextBox();
            this.lblBData = new System.Windows.Forms.Label();
            this.txtMeanB = new System.Windows.Forms.TextBox();
            this.lblMeanB = new System.Windows.Forms.Label();
            this.txtMeanDiff = new System.Windows.Forms.TextBox();
            this.lblMeanDiff = new System.Windows.Forms.Label();
            this.txtCL = new System.Windows.Forms.TextBox();
            this.lblCL = new System.Windows.Forms.Label();
            this.lblNullH = new System.Windows.Forms.Label();
            this.chkPaired = new System.Windows.Forms.CheckBox();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.lblIterations = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(487, 441);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 57);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDataA
            // 
            this.txtDataA.Location = new System.Drawing.Point(16, 65);
            this.txtDataA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataA.MaxLength = 0;
            this.txtDataA.Multiline = true;
            this.txtDataA.Name = "txtDataA";
            this.txtDataA.Size = new System.Drawing.Size(204, 404);
            this.txtDataA.TabIndex = 1;
            // 
            // txtCILow
            // 
            this.txtCILow.Location = new System.Drawing.Point(563, 298);
            this.txtCILow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCILow.Name = "txtCILow";
            this.txtCILow.ReadOnly = true;
            this.txtCILow.Size = new System.Drawing.Size(132, 22);
            this.txtCILow.TabIndex = 2;
            // 
            // lblCILow
            // 
            this.lblCILow.AutoSize = true;
            this.lblCILow.Location = new System.Drawing.Point(501, 302);
            this.lblCILow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCILow.Name = "lblCILow";
            this.lblCILow.Size = new System.Drawing.Size(49, 17);
            this.lblCILow.TabIndex = 3;
            this.lblCILow.Text = "CI Low";
            // 
            // txtCIHigh
            // 
            this.txtCIHigh.Location = new System.Drawing.Point(563, 354);
            this.txtCIHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCIHigh.Name = "txtCIHigh";
            this.txtCIHigh.ReadOnly = true;
            this.txtCIHigh.Size = new System.Drawing.Size(132, 22);
            this.txtCIHigh.TabIndex = 4;
            // 
            // lblCIHigh
            // 
            this.lblCIHigh.AutoSize = true;
            this.lblCIHigh.Location = new System.Drawing.Point(499, 358);
            this.lblCIHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCIHigh.Name = "lblCIHigh";
            this.lblCIHigh.Size = new System.Drawing.Size(53, 17);
            this.lblCIHigh.TabIndex = 5;
            this.lblCIHigh.Text = "CI High";
            // 
            // txtMeanA
            // 
            this.txtMeanA.Location = new System.Drawing.Point(563, 209);
            this.txtMeanA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMeanA.Name = "txtMeanA";
            this.txtMeanA.ReadOnly = true;
            this.txtMeanA.Size = new System.Drawing.Size(132, 22);
            this.txtMeanA.TabIndex = 6;
            // 
            // lblMeanA
            // 
            this.lblMeanA.AutoSize = true;
            this.lblMeanA.Location = new System.Drawing.Point(496, 213);
            this.lblMeanA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeanA.Name = "lblMeanA";
            this.lblMeanA.Size = new System.Drawing.Size(56, 17);
            this.lblMeanA.TabIndex = 7;
            this.lblMeanA.Text = "Mean A";
            // 
            // lblDataA
            // 
            this.lblDataA.AutoSize = true;
            this.lblDataA.Location = new System.Drawing.Point(16, 46);
            this.lblDataA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataA.Name = "lblDataA";
            this.lblDataA.Size = new System.Drawing.Size(51, 17);
            this.lblDataA.TabIndex = 8;
            this.lblDataA.Text = "Data A";
            // 
            // txtDataB
            // 
            this.txtDataB.Location = new System.Drawing.Point(247, 65);
            this.txtDataB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataB.MaxLength = 0;
            this.txtDataB.Multiline = true;
            this.txtDataB.Name = "txtDataB";
            this.txtDataB.Size = new System.Drawing.Size(204, 404);
            this.txtDataB.TabIndex = 9;
            // 
            // lblBData
            // 
            this.lblBData.AutoSize = true;
            this.lblBData.Location = new System.Drawing.Point(255, 46);
            this.lblBData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBData.Name = "lblBData";
            this.lblBData.Size = new System.Drawing.Size(51, 17);
            this.lblBData.TabIndex = 10;
            this.lblBData.Text = "Data B";
            // 
            // txtMeanB
            // 
            this.txtMeanB.Location = new System.Drawing.Point(563, 241);
            this.txtMeanB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMeanB.Name = "txtMeanB";
            this.txtMeanB.ReadOnly = true;
            this.txtMeanB.Size = new System.Drawing.Size(132, 22);
            this.txtMeanB.TabIndex = 11;
            // 
            // lblMeanB
            // 
            this.lblMeanB.AutoSize = true;
            this.lblMeanB.Location = new System.Drawing.Point(496, 245);
            this.lblMeanB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeanB.Name = "lblMeanB";
            this.lblMeanB.Size = new System.Drawing.Size(56, 17);
            this.lblMeanB.TabIndex = 12;
            this.lblMeanB.Text = "Mean B";
            // 
            // txtMeanDiff
            // 
            this.txtMeanDiff.Location = new System.Drawing.Point(563, 326);
            this.txtMeanDiff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMeanDiff.Name = "txtMeanDiff";
            this.txtMeanDiff.ReadOnly = true;
            this.txtMeanDiff.Size = new System.Drawing.Size(132, 22);
            this.txtMeanDiff.TabIndex = 13;
            // 
            // lblMeanDiff
            // 
            this.lblMeanDiff.AutoSize = true;
            this.lblMeanDiff.Location = new System.Drawing.Point(484, 330);
            this.lblMeanDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeanDiff.Name = "lblMeanDiff";
            this.lblMeanDiff.Size = new System.Drawing.Size(68, 17);
            this.lblMeanDiff.TabIndex = 14;
            this.lblMeanDiff.Text = "Mean Diff";
            // 
            // txtCL
            // 
            this.txtCL.Location = new System.Drawing.Point(563, 119);
            this.txtCL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(85, 22);
            this.txtCL.TabIndex = 15;
            this.txtCL.Text = "95.0";
            // 
            // lblCL
            // 
            this.lblCL.AutoSize = true;
            this.lblCL.Location = new System.Drawing.Point(514, 122);
            this.lblCL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(41, 17);
            this.lblCL.TabIndex = 16;
            this.lblCL.Text = "CL %";
            // 
            // lblNullH
            // 
            this.lblNullH.AutoSize = true;
            this.lblNullH.Location = new System.Drawing.Point(524, 402);
            this.lblNullH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNullH.Name = "lblNullH";
            this.lblNullH.Size = new System.Drawing.Size(42, 17);
            this.lblNullH.TabIndex = 17;
            this.lblNullH.Text = "H0 = ";
            // 
            // chkPaired
            // 
            this.chkPaired.AutoSize = true;
            this.chkPaired.Location = new System.Drawing.Point(563, 26);
            this.chkPaired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPaired.Name = "chkPaired";
            this.chkPaired.Size = new System.Drawing.Size(105, 21);
            this.chkPaired.TabIndex = 18;
            this.chkPaired.Text = "Paired Data";
            this.chkPaired.UseVisualStyleBackColor = true;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(563, 54);
            this.rbOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(99, 21);
            this.rbOne.TabIndex = 19;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "One Tailed";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Checked = true;
            this.rbTwo.Location = new System.Drawing.Point(563, 81);
            this.rbTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(98, 21);
            this.rbTwo.TabIndex = 20;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "Two Tailed";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(489, 151);
            this.lblIterations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(66, 17);
            this.lblIterations.TabIndex = 21;
            this.lblIterations.Text = "Iterations";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(563, 148);
            this.txtIterations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(54, 22);
            this.txtIterations.TabIndex = 22;
            this.txtIterations.Text = "10";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(624, 151);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(17, 17);
            this.lblK.TabIndex = 23;
            this.lblK.Text = "K";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 526);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.lblIterations);
            this.Controls.Add(this.rbTwo);
            this.Controls.Add(this.rbOne);
            this.Controls.Add(this.chkPaired);
            this.Controls.Add(this.lblNullH);
            this.Controls.Add(this.lblCL);
            this.Controls.Add(this.txtCL);
            this.Controls.Add(this.lblMeanDiff);
            this.Controls.Add(this.txtMeanDiff);
            this.Controls.Add(this.lblMeanB);
            this.Controls.Add(this.txtMeanB);
            this.Controls.Add(this.lblBData);
            this.Controls.Add(this.txtDataB);
            this.Controls.Add(this.lblDataA);
            this.Controls.Add(this.lblMeanA);
            this.Controls.Add(this.txtMeanA);
            this.Controls.Add(this.lblCIHigh);
            this.Controls.Add(this.txtCIHigh);
            this.Controls.Add(this.lblCILow);
            this.Controls.Add(this.txtCILow);
            this.Controls.Add(this.txtDataA);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bootstrap CI Calculator v1.21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDataA;
        private System.Windows.Forms.TextBox txtCILow;
        private System.Windows.Forms.Label lblCILow;
        private System.Windows.Forms.TextBox txtCIHigh;
        private System.Windows.Forms.Label lblCIHigh;
        private System.Windows.Forms.TextBox txtMeanA;
        private System.Windows.Forms.Label lblMeanA;
        private System.Windows.Forms.Label lblDataA;
        private System.Windows.Forms.TextBox txtDataB;
        private System.Windows.Forms.Label lblBData;
        private System.Windows.Forms.TextBox txtMeanB;
        private System.Windows.Forms.Label lblMeanB;
        private System.Windows.Forms.TextBox txtMeanDiff;
        private System.Windows.Forms.Label lblMeanDiff;
        private System.Windows.Forms.TextBox txtCL;
        private System.Windows.Forms.Label lblCL;
        private System.Windows.Forms.Label lblNullH;
        private System.Windows.Forms.CheckBox chkPaired;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label lblK;
    }
}

