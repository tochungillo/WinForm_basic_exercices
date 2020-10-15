using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_basic_exercices_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String chosen = "Choosen animals:";
            if (mouse.Checked)
                chosen += " mouse";
            if (cat.Checked)
                chosen += " cat";
            if (dog.Checked)
                chosen += " dog";
            choosen.Text = chosen;
        }
    }
}
