using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_basic_exercices_4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString().Equals("+"))
            {
                operation.Text = "+";
                sum();
            }
            if (listBox1.SelectedItem.ToString().Equals("-"))
            {
                operation.Text = "-";
                substract();
            }
        }

        public void sum()
        {
            try
            {
                result.Text = (Int32.Parse(operand1.Text) + Int32.Parse(operand2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduce numeros para realizar la suma");
            }
        }
        public void substract()
        {
            try
            {
                result.Text = (Int32.Parse(operand1.Text) - Int32.Parse(operand2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduce numeros para realizar la substraccion");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operation.Text.Equals("+"))
                sum();
            else
            {
                if (operation.Text.Equals("-"))
                    substract();
                else
                    MessageBox.Show("introduce una operacion");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operand1.Text = "";
            operand2.Text = "";
            operation.Text = "";
        }
    }
}
