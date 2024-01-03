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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Не сте въвели разстояние/среден разход в някоя от текстовите кутии", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (double.TryParse(textBox1.Text, out double f) && double.TryParse(textBox2.Text, out double g) && double.TryParse(textBox3.Text, out double h) && double.TryParse(textBox4.Text, out double m))
                {
                    if (checkBox2.Checked && checkBox4.Checked)
                    {
                        double rb = double.Parse(textBox1.Text);
                        double srb = double.Parse(textBox2.Text);
                        double srg = double.Parse(textBox3.Text);
                        double rg = double.Parse(textBox4.Text);
                        if (rb <= 0 || srb <= 0 || srg <= 0 || rg <= 0)
                        {
                            MessageBox.Show("Не могат да се въвеждат отрицателни или нулеви стойности", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            double ob = rb + rg;
                            double ob1 = ob;
                            ob1 = Math.Round(ob1, 3);
                            label18.Text = "Общо разстояние- " + ob1 + " км.";
                            double price2 = 1.2;
                            double price = 2.4;
                            double l = (rb / 100) * srb;
                            l = Math.Round(l, 2);
                            label4.Text = l + " литра за бензин";
                            label5.Text = Math.Round(l * price, 2) + " лева/лев за бензин";
                            double l2 = (rg / 100) * srg;
                            l2 = Math.Round(l2, 2);
                            label14.Text = l2 + " литра за газ";
                            label13.Text = Math.Round(l2 * price2, 2) + " лева/лев за газ";
                            label15.Text = Math.Round(l2 + l, 2) + " литра";
                            label17.Text = Math.Round((l * price) + (l2 * price2), 2) + " лева";
                            if (checkBox1.Checked)
                            {
                                label18.Text = "Общо разстояние- " + ob1 * 2 + " км.";
                                price2 = 1.2 * 2;
                                price = 2.4 * 2;
                                l = (rb / 100) * srb;
                                label4.Text = Math.Round(l * 2,2) + " литра за бензин";
                                label5.Text = Math.Round(l * price,2) + " лева/лев за бензин";
                                label14.Text = Math.Round(l2 * 2,2) + " литра за газ";
                                label13.Text = Math.Round(l2 * price2,2) + " лева/лев за газ";
                                label15.Text = Math.Round(l2 * 2 + l * 2,2) + " литра";
                                label17.Text = Math.Round((l * price) + (l2 * price2),2) + " лева";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не сте отбелязали горивата!");
                    }
                }
                else
                {
                    MessageBox.Show("Въвели сте нещо различно с/без/от число в някоя от текстовите кутии!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Сметката не може да бъде извършена!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
