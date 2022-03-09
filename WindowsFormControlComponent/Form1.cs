using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormControlComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            labelOutput.Text = txtBoxInput.Text;
        }

        private void radioButtRed_CheckedChanged(object sender, EventArgs e)
        {
            labelOutput.ForeColor = Color.Red;
        }

        private void radioButtBlue_CheckedChanged(object sender, EventArgs e)
        {
            labelOutput.ForeColor = Color.Blue;
        }

        private void cBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            fontStyleOrganizer();
        }

        private void cBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            fontStyleOrganizer();
        }

        private void cBoxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            fontStyleOrganizer();
        }

        public void fontStyleOrganizer()
        {
            labelOutput.Font = new Font(labelOutput.Font, FontStyle.Regular);
            if (cBoxUnderline.Checked == true)
            {
                labelOutput.Font = new Font(labelOutput.Font, labelOutput.Font.Style | FontStyle.Underline);
            }
            if (cBoxItalic.Checked == true)
            {
                labelOutput.Font = new Font(labelOutput.Font, labelOutput.Font.Style | FontStyle.Italic);
            }
            if (cBoxBold.Checked == true)
            {
                labelOutput.Font = new Font(labelOutput.Font, labelOutput.Font.Style | FontStyle.Bold);
            }
        }
    }
}
