using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TaskGas_Station
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == ""||textBox3.Text==""||textBox4.Text=="")
            {
                MessageBox.Show("Не сте въвели разстояние/среден разход за двете горива", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBox2.Checked&&checkBox4.Checked)
                {
                    
                    double rb = double.Parse(textBox1.Text);
                    double srb = double.Parse(textBox2.Text);
                    double srg = double.Parse(textBox3.Text);
                    double rg= double.Parse(textBox4.Text);
                    if (double.Parse(textBox1.Text) <= 0 || double.Parse(textBox2.Text) <= 0 || double.Parse(textBox3.Text) <= 0 || double.Parse(textBox4.Text) <= 0)
                    {
                        MessageBox.Show("Не могат да се въвеждат отрицателни или нулеви стойности", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        double ob = double.Parse(textBox1.Text)+ double.Parse(textBox4.Text);
                        label18.Text = "Общо разстояние- " + ob +" км.";
                        double price2 = 1.2;
                        double price = 2.4;
                        double l = (rb / 100) * srb;
                        label4.Text = l + " литра за бензин";
                        label5.Text = l * price + " лева/лев за бензин";
                        double l2 = (rg / 100) * srg;
                        label14.Text = l2 + " литра за газ";
                        label13.Text = l2 * price2 + " лева/лев за газ";
                        label15.Text = l2 + l + " литра";
                        label17.Text = (l * price) +( l2 * price2) + " лева";
                        if(checkBox1.Checked)
                        {
                            label18.Text = "Общо разстояние- " + ob*2 + " км.";
                            price2 = 1.2 * 2;
                            price = 2.4 * 2;
                            l= (rb / 100) * srb;
                            label4.Text = l*2 + " литра за бензин";
                            label5.Text = l * price + " лева/лев за бензин";
                            l2= (rg / 100) * srg;
                            label14.Text = l2*2 + " литра за газ";
                            label13.Text = l2 * price2 + " лева/лев за газ";
                            label15.Text = l2*2 + l*2 + " литра";
                            label17.Text = (l * price) + (l2 * price2) + " лева";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не си отбелязали горивата!");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            foreach (var item in groupBox1.Controls)
            {
                if (item is Label) ((Label)item).Text = "...";
            }
            //foreach (var item in groupBox1.It)
            //{
            //    //if(item is label4,label5,label14,label15,label13,label17) ((label4,label5,label14,label15,label13,label17)item).Text = "";
            //    if (item is Label) ((Label)item).Text = $"{label4} {label5} {label14} {label15} {label17} {label13}";
            //}
        }
        //if (checkBox1.Checked)
        //{
        //    l = (r / 100) * sr;
        //    label4.Text = l * 2 + " литра";
        //    label5.Text = (l * 2) * price + " лева/лев";
        //}
        //if (checkBox3.Checked && checkBox2.Checked && checkBox4.Checked)
        //{
        //    double l = (r / 100) * sr;
        //    label4.Text = l + " литра";
        //    label5.Text = l * (price - price2) + " лева/лев";
        //    if (checkBox1.Checked)
        //    {
        //        l = (r / 100) * sr;
        //        label4.Text = l * 2 + " литра";
        //        label5.Text = (l * 2) * price2 + price + " лева/лев";
        //    }
        //}
        //else
        //{
        //    if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
        //    {
        //        double l2 = (r / 100) * sr;
        //        label4.Text = l2 + " литра";
        //        label5.Text = l2 * price2 + price + " лева/лев";
        //    }
        //    if (checkBox1.Checked)
        //    {
        //        double l2 = (r / 100) * sr;
        //        label4.Text = l2 * 2 + " литра";
        //        label5.Text = (l2 * 2) * price2 + price + " лева/лев";
        //    }
        //}
    }
}
