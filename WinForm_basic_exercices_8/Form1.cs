using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_basic_exercices_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] grupA =
        {
            "Juan",
            "Maria",
            "Pepa"
        };
        String[] grupB =
        {
            "MisterX",
            "Biowong",
            "XQ"
        };
        public void asignar(String[] grup)
        {
            for (int i = 0; i < grup.Length; i++)
            {
                classroom.Items.Add(grup[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
            asignar(grupA);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
            asignar(grupB);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            classroom.Items.Clear();
        }

        private void classroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected.Text = classroom.SelectedItem.ToString();
        }
    }
}
