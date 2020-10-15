using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_basic_exercices_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            barra.Minimum = 50;
            barra.Maximum = 89;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            porcentaje.Text = barra.Value.ToString();
        }

        private void porcentaje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = 0;
                if (porcentaje.Text.Equals(""))
                    value = 0;
                else 
                    value = Int32.Parse(porcentaje.Text.ToString());
                if (value < 50 || value > 80) throw new Exception();
                barra.Value = value;
            } catch (Exception ex)
            {
                MessageBox.Show("Introduce un valor entre 0 y 90");
            }
        }
    }
}
