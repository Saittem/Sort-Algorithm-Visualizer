using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Globalization;
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
        float columnWidth;
        Graphics g;
        Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            maxValue = panel.Height;
            g = panel.CreateGraphics();

            algorithmBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numEntries = (int)numCount.Value;
            array = new int[numEntries];
            Random random = new Random();
            panel.Controls.Clear();
            panel.Refresh();
            columnWidth = Math.Abs(panel.Width / numEntries);

            for (int i = 0; i < numEntries; i++)
            {
                array[i] = random.Next(0, maxValue);
            }

            for (int i = 0; i < numEntries; i++)
            {
                g.FillRectangle(Brushes.White, i * columnWidth, maxValue - array[i], columnWidth - 1, array[i]);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            stopwatch.Start();

            if (algorithmBox.Text == "BubbleSort")
            {
                BubbleSort bubbleSort = new BubbleSort();

                if (bubbleSort.Sort(array, g, maxValue, columnWidth))
                {
                    stopwatch.Stop();
                    MessageBox.Show(stopwatch.Elapsed.ToString());
                }
            }
            else if (algorithmBox.Text == "InsertSort")
            {

            }
            else if (algorithmBox.Text == "BogoSort")
            {
                BogoSort bogoSort = new BogoSort();

                if (bogoSort.Sort(array, g, maxValue, columnWidth))
                {
                    stopwatch.Stop();
                    MessageBox.Show(stopwatch.Elapsed.ToString());
                }
            }
            else if (algorithmBox.Text == "StalinSort")
            {

            }
            else
            {
                MessageBox.Show("Prosím vyberte jaký třídící algoritmus chcete.");
            }
        }
    }
}
