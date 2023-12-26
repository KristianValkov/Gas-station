using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskGas_Station
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 form1= new Form1();
            //form1.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            foreach (var item in groupBox1.Controls)
            {
                if (item is Label) ((Label)item).Text = "...";
            }
            if(button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.White;
            }
            else
            {
               button1.BackColor= Color.Yellow;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor=Color.White;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Не сте въвели разстояние/среден разход", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
                {
                    
                    double r = double.Parse(textBox1.Text);
                    double sr = double.Parse(textBox2.Text);
                    if (double.Parse(textBox1.Text) <= 0 || double.Parse(textBox2.Text) <= 0)
                    {
                        MessageBox.Show("Не могат да се въвеждат отрицателни или нулеви стойности", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        double price2 = 1.2;
                        double price = 2.4;
                        if (radioButton2.Checked || radioButton1.Checked)
                        {
                            double l = (r / 100) * sr;
                            label4.Text = l + " литра";
                            label5.Text = l * price + " лева/лев";
                            if (checkBox1.Checked)
                            {
                                l = (r / 100) * sr;
                                label4.Text = l * 2 + " литра";
                                label5.Text = (l * 2) * price + " лева/лев";
                            }
                        }
                        else
                        {
                            double l2 = (r / 100) * sr;
                            label4.Text = l2 + " литра";
                            label5.Text = l2 * price2 + " лева/лев";
                            if (checkBox1.Checked)
                            {
                                l2 = (r / 100) * sr;
                                label4.Text = l2 * 2 + " литра";
                                label5.Text = (l2 * 2) * price2 + " лева/лев";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не си отбелязал какво гориво искаш!");
                }
            }
            //if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            //{
            //    //string t = textBox1.Text;
            //    //string v = textBox2.Text;
            //    double price = 2.4;
            //    double r = double.Parse(textBox1.Text);
            //    double sr = double.Parse(textBox2.Text);
            //    //if(double.Parse(textBox1.Text)==t)
            //    //{
            //    //    return;
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("Не sijjlfjg", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //}
            //    if (double.Parse(textBox1.Text) <= 0 || double.Parse(textBox2.Text) <= 0) //|| t.ToString()==""|| v.ToString()=="")
            //    {
            //       MessageBox.Show("Не могат да се въвеждат отрицателни или нулеви стойности", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        double l = (r / 100) * sr;
            //        label4.Text = l + " литра";
            //        label5.Text = l * price + " лева/лев";
            //        if (checkBox1.Checked)
            //        {
            //            l = (r / 100) * sr;
            //            label4.Text = l * 2 + " литра";
            //            label5.Text = (l*2)* price + " лева/лев";
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Не си отбелязал какво гориво искаш!");
            //}
        }
    }
}
