namespace Bootstrap_CI_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(365, 358);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 46);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDataA
            // 
            this.txtDataA.Location = new System.Drawing.Point(12, 53);
            this.txtDataA.MaxLength = 0;
            this.txtDataA.Multiline = true;
            this.txtDataA.Name = "txtDataA";
            this.txtDataA.Size = new System.Drawing.Size(154, 329);
            this.txtDataA.TabIndex = 1;
            // 
            // txtCILow
            // 
            this.txtCILow.Location = new System.Drawing.Point(422, 242);
            this.txtCILow.Name = "txtCILow";
            this.txtCILow.ReadOnly = true;
            this.txtCILow.Size = new System.Drawing.Size(100, 20);
            this.txtCILow.TabIndex = 2;
            // 
            // lblCILow
            // 
            this.lblCILow.AutoSize = true;
            this.lblCILow.Location = new System.Drawing.Point(376, 245);
            this.lblCILow.Name = "lblCILow";
            this.lblCILow.Size = new System.Drawing.Size(40, 13);
            this.lblCILow.TabIndex = 3;
            this.lblCILow.Text = "CI Low";
            // 
            // txtCIHigh
            // 
            this.txtCIHigh.Location = new System.Drawing.Point(422, 288);
            this.txtCIHigh.Name = "txtCIHigh";
            this.txtCIHigh.ReadOnly = true;
            this.txtCIHigh.Size = new System.Drawing.Size(100, 20);
            this.txtCIHigh.TabIndex = 4;
            // 
            // lblCIHigh
            // 
            this.lblCIHigh.AutoSize = true;
            this.lblCIHigh.Location = new System.Drawing.Point(374, 291);
            this.lblCIHigh.Name = "lblCIHigh";
            this.lblCIHigh.Size = new System.Drawing.Size(42, 13);
            this.lblCIHigh.TabIndex = 5;
            this.lblCIHigh.Text = "CI High";
            // 
            // txtMeanA
            // 
            this.txtMeanA.Location = new System.Drawing.Point(422, 170);
            this.txtMeanA.Name = "txtMeanA";
            this.txtMeanA.ReadOnly = true;
            this.txtMeanA.Size = new System.Drawing.Size(100, 20);
            this.txtMeanA.TabIndex = 6;
            // 
            // lblMeanA
            // 
            this.lblMeanA.AutoSize = true;
            this.lblMeanA.Location = new System.Drawing.Point(372, 173);
            this.lblMeanA.Name = "lblMeanA";
            this.lblMeanA.Size = new System.Drawing.Size(44, 13);
            this.lblMeanA.TabIndex = 7;
            this.lblMeanA.Text = "Mean A";
            // 
            // lblDataA
            // 
            this.lblDataA.AutoSize = true;
            this.lblDataA.Location = new System.Drawing.Point(12, 37);
            this.lblDataA.Name = "lblDataA";
            this.lblDataA.Size = new System.Drawing.Size(40, 13);
            this.lblDataA.TabIndex = 8;
            this.lblDataA.Text = "Data A";
            // 
            // txtDataB
            // 
            this.txtDataB.Location = new System.Drawing.Point(185, 53);
            this.txtDataB.MaxLength = 0;
            this.txtDataB.Multiline = true;
            this.txtDataB.Name = "txtDataB";
            this.txtDataB.Size = new System.Drawing.Size(154, 329);
            this.txtDataB.TabIndex = 9;
            // 
            // lblBData
            // 
            this.lblBData.AutoSize = true;
            this.lblBData.Location = new System.Drawing.Point(191, 37);
            this.lblBData.Name = "lblBData";
            this.lblBData.Size = new System.Drawing.Size(40, 13);
            this.lblBData.TabIndex = 10;
            this.lblBData.Text = "Data B";
            // 
            // txtMeanB
            // 
            this.txtMeanB.Location = new System.Drawing.Point(422, 196);
            this.txtMeanB.Name = "txtMeanB";
            this.txtMeanB.ReadOnly = true;
            this.txtMeanB.Size = new System.Drawing.Size(100, 20);
            this.txtMeanB.TabIndex = 11;
            // 
            // lblMeanB
            // 
            this.lblMeanB.AutoSize = true;
            this.lblMeanB.Location = new System.Drawing.Point(372, 199);
            this.lblMeanB.Name = "lblMeanB";
            this.lblMeanB.Size = new System.Drawing.Size(44, 13);
            this.lblMeanB.TabIndex = 12;
            this.lblMeanB.Text = "Mean B";
            // 
            // txtMeanDiff
            // 
            this.txtMeanDiff.Location = new System.Drawing.Point(422, 265);
            this.txtMeanDiff.Name = "txtMeanDiff";
            this.txtMeanDiff.ReadOnly = true;
            this.txtMeanDiff.Size = new System.Drawing.Size(100, 20);
            this.txtMeanDiff.TabIndex = 13;
            // 
            // lblMeanDiff
            // 
            this.lblMeanDiff.AutoSize = true;
            this.lblMeanDiff.Location = new System.Drawing.Point(363, 268);
            this.lblMeanDiff.Name = "lblMeanDiff";
            this.lblMeanDiff.Size = new System.Drawing.Size(53, 13);
            this.lblMeanDiff.TabIndex = 14;
            this.lblMeanDiff.Text = "Mean Diff";
            // 
            // txtCL
            // 
            this.txtCL.Location = new System.Drawing.Point(422, 97);
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(65, 20);
            this.txtCL.TabIndex = 15;
            this.txtCL.Text = "95.0";
            // 
            // lblCL
            // 
            this.lblCL.AutoSize = true;
            this.lblCL.Location = new System.Drawing.Point(377, 100);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(31, 13);
            this.lblCL.TabIndex = 16;
            this.lblCL.Text = "CL %";
            // 
            // lblNullH
            // 
            this.lblNullH.AutoSize = true;
            this.lblNullH.Location = new System.Drawing.Point(393, 327);
            this.lblNullH.Name = "lblNullH";
            this.lblNullH.Size = new System.Drawing.Size(33, 13);
            this.lblNullH.TabIndex = 17;
            this.lblNullH.Text = "H0 = ";
            // 
            // chkPaired
            // 
            this.chkPaired.AutoSize = true;
            this.chkPaired.Location = new System.Drawing.Point(422, 21);
            this.chkPaired.Name = "chkPaired";
            this.chkPaired.Size = new System.Drawing.Size(82, 17);
            this.chkPaired.TabIndex = 18;
            this.chkPaired.Text = "Paired Data";
            this.chkPaired.UseVisualStyleBackColor = true;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(422, 44);
            this.rbOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(77, 17);
            this.rbOne.TabIndex = 19;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "One Tailed";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Checked = true;
            this.rbTwo.Location = new System.Drawing.Point(422, 66);
            this.rbTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(78, 17);
            this.rbTwo.TabIndex = 20;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "Two Tailed";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(356, 123);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(60, 13);
            this.lblIterations.TabIndex = 21;
            this.lblIterations.Text = "Iterations K";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(422, 120);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(60, 20);
            this.txtIterations.TabIndex = 22;
            this.txtIterations.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 427);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bootstrap CI Calculator v1.2";
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
    }
}

