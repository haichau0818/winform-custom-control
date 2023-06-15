using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRadius1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textboxCustom1.Text);
        }

        private void datimePickerCustom1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
