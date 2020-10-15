using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_basic_exercices_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int op1 = Int32.Parse(operand1.Text);
                int op2 = Int32.Parse(operand2.Text);
                int res = op1 + op2;
                result.Text = res.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show("Por favor introduce valores numericos en los operadores");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operand1.Text = "";
            operand2.Text = "";
        }
    }
}
