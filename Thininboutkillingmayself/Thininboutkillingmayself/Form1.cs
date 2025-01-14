using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thininboutkillingmayself
{
    public partial class Form1 : Form
    {
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBit5_TextChanged(object sender, EventArgs e)
        {
            total = 0; 
            if (textBoxBit1.Text == "1")
            {
                total += 1;
            }
            if (textBoxBit2.Text == "1")
            {
                total += 2;
            }
            if (textBoxBit3.Text == "1")
            {
                total += 4;
            }
            if (textBoxBit4.Text == "1")
            {
                total += 8;
            }
            if (textBoxBit5.Text == "1")
            {
                total += 16;
            }
            if (textBoxBit6.Text == "1")
            {
                total += 32;
            }
            if (textBoxBit7.Text == "1")
            {
                total += 64;
            }
            if (textBoxBit8.Text == "1")
            {
                total += 128;
            }
            label1.Text = total.ToString();
        }
    }
}
