﻿using System;
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
                    if(double.TryParse(textBox1.Text,out double g)&& double.TryParse(textBox2.Text, out double h))
                    {
                        double r = double.Parse(textBox1.Text);
                        double sr = double.Parse(textBox2.Text);
                        if (r <= 0 || sr <= 0)
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
                                double l1 = l;
                                double p1 = Math.Round(l * price,2);
                                l1 = Math.Round(l1, 2);
                                label4.Text = l1 + " литра";
                                label5.Text = p1 + " лева/лев";
                                if (checkBox1.Checked)
                                {

                                    label4.Text = l1 * 2 + " литра";
                                    label5.Text = p1 * 2 + " лева/лев";
                                }
                            }
                            else
                            {
                                double l2 = (r / 100) * sr;
                                l2 = Math.Round(l2, 2);
                                double pT2 = Math.Round(l2 * price2, 2);
                                label4.Text = l2 + " литра";
                                label5.Text = pT2 + " лева/лев";
                                if (checkBox1.Checked)
                                {
                                    label4.Text = l2 * 2 + " литра";
                                    label5.Text = pT2 * 2 + " лева/лев";
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Въвели сте нещо различно с/без/от число в някоя от текстовите кутии!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Сметката не може да бъде извършена!","Грешка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не сте отбелязали какво гориво искате!");
                }
            }
        }
    }
}
