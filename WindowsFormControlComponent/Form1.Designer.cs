namespace WindowsFormControlComponent
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
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBold = new System.Windows.Forms.CheckBox();
            this.cBoxItalic = new System.Windows.Forms.CheckBox();
            this.cBoxUnderline = new System.Windows.Forms.CheckBox();
            this.radioButtRed = new System.Windows.Forms.RadioButton();
            this.radioButtBlue = new System.Windows.Forms.RadioButton();
            this.labelOutput = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(67, 31);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input :";
            // 
            // cBoxBold
            // 
            this.cBoxBold.AutoSize = true;
            this.cBoxBold.Location = new System.Drawing.Point(67, 81);
            this.cBoxBold.Name = "cBoxBold";
            this.cBoxBold.Size = new System.Drawing.Size(47, 17);
            this.cBoxBold.TabIndex = 2;
            this.cBoxBold.Text = "Bold";
            this.cBoxBold.UseVisualStyleBackColor = true;
            this.cBoxBold.CheckedChanged += new System.EventHandler(this.cBoxBold_CheckedChanged);
            // 
            // cBoxItalic
            // 
            this.cBoxItalic.AutoSize = true;
            this.cBoxItalic.Location = new System.Drawing.Point(154, 81);
            this.cBoxItalic.Name = "cBoxItalic";
            this.cBoxItalic.Size = new System.Drawing.Size(48, 17);
            this.cBoxItalic.TabIndex = 3;
            this.cBoxItalic.Text = "Italic";
            this.cBoxItalic.UseVisualStyleBackColor = true;
            this.cBoxItalic.CheckedChanged += new System.EventHandler(this.cBoxItalic_CheckedChanged);
            // 
            // cBoxUnderline
            // 
            this.cBoxUnderline.AutoSize = true;
            this.cBoxUnderline.Location = new System.Drawing.Point(240, 81);
            this.cBoxUnderline.Name = "cBoxUnderline";
            this.cBoxUnderline.Size = new System.Drawing.Size(71, 17);
            this.cBoxUnderline.TabIndex = 4;
            this.cBoxUnderline.Text = "Underline";
            this.cBoxUnderline.UseVisualStyleBackColor = true;
            this.cBoxUnderline.CheckedChanged += new System.EventHandler(this.cBoxUnderline_CheckedChanged);
            // 
            // radioButtRed
            // 
            this.radioButtRed.AutoSize = true;
            this.radioButtRed.Location = new System.Drawing.Point(67, 117);
            this.radioButtRed.Name = "radioButtRed";
            this.radioButtRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtRed.TabIndex = 5;
            this.radioButtRed.Text = "Red";
            this.radioButtRed.UseVisualStyleBackColor = true;
            this.radioButtRed.CheckedChanged += new System.EventHandler(this.radioButtRed_CheckedChanged);
            // 
            // radioButtBlue
            // 
            this.radioButtBlue.AutoSize = true;
            this.radioButtBlue.Location = new System.Drawing.Point(154, 117);
            this.radioButtBlue.Name = "radioButtBlue";
            this.radioButtBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtBlue.TabIndex = 6;
            this.radioButtBlue.Text = "Blue";
            this.radioButtBlue.UseVisualStyleBackColor = true;
            this.radioButtBlue.CheckedChanged += new System.EventHandler(this.radioButtBlue_CheckedChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(62, 176);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(70, 25);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "label2";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(173, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.radioButtBlue);
            this.Controls.Add(this.radioButtRed);
            this.Controls.Add(this.cBoxUnderline);
            this.Controls.Add(this.cBoxItalic);
            this.Controls.Add(this.cBoxBold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBoxBold;
        private System.Windows.Forms.CheckBox cBoxItalic;
        private System.Windows.Forms.CheckBox cBoxUnderline;
        private System.Windows.Forms.RadioButton radioButtRed;
        private System.Windows.Forms.RadioButton radioButtBlue;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button btnPrint;
    }
}

