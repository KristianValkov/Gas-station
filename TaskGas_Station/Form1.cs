using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskGas_Station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            if(radioButton1.Checked)
            {
                f2.Show();
            }
            if(radioButton2.Checked)
            {
                f3.Show();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
