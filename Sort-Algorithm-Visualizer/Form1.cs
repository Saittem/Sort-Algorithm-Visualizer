using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_Algorithm_Visualizer
{
    public partial class Form1 : Form
    {
        int maxValue;
        int numEntries;
        int[] array;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            maxValue = panel.Height;
            numEntries = panel.Width;
            g = panel.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            array = new int[numEntries];
            Random random = new Random();
            for (int i = 0; i < numEntries; i++)
            {
                array[i] = random.Next(0, maxValue);
            }
            for (int i = 0; i < numEntries; i++)
            {
                g.FillRectangle(Brushes.White, i, maxValue - array[i], 1, maxValue);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }
    }
}
