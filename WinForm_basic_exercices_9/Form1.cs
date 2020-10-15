using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_basic_exercices_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numbers.Items.Clear();
            for (int i = 1; i < 11; i++)
                if (i % 2 == 0) numbers.Items.Add(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbers.Items.Clear();
            for (int i = 1; i < 11; i++)
                if (i % 2 != 0) numbers.Items.Add(i);
        }

        private void numbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected.Text = numbers.SelectedItem.ToString();
        }
    }
}
