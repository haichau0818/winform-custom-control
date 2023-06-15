using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CustomControlsUI.Forms
{
    public partial class fFormBoderRadius : Form
    {


        //style form border radius

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
         int nLeftRect,
         int nTopRect,
         int RightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse

         );

        public fFormBoderRadius()
        {
            InitializeComponent();

            //set
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void fFormBoderRadius_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarCustom1.Value<progressBarCustom1.Maximum)
            {
                progressBarCustom1.Value++;
                
            }else
                toggleButton1.Checked = !toggleButton1.Checked;


        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton1.Checked)
            {
                timer1.Start();
                progressBarCustom1.Value = 0;

            }else

            timer1.Stop();
         
                

        }
        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            pnlActive.Width += 3;
            if (i<=100)
            {
                i++;
                label1.Text = i.ToString();
            }
            
            if (pnlActive.Width>=800)
            {
                timer2.Stop();
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
