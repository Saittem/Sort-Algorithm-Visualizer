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
            panel.Controls.Clear();
            panel.Refresh();

            for (int i = 0; i < numEntries; i++)
            {
                array[i] = random.Next(0, maxValue);
            }

            /*if (algorithmBox.Text == "BubbleSort Random")
            {
                for (int i = 0; i < numEntries; i++)
                {
                    array[i] = random.Next(0, maxValue);
                }
            }
            else if (algorithmBox.Text == "BubbleSort Posloupně")
            {
                HashSet<int> usedNumbers = new HashSet<int>();

                for (int i = 0; i < numEntries; i++)
                {
                    int number;

                    do
                    {
                        number = random.Next(0, maxValue);
                    }
                    while (usedNumbers.Contains(number));

                    array[i] = number;
                    usedNumbers.Add(number);
                }
            }*/

            for (int i = 0; i < numEntries; i++)
            {
                g.FillRectangle(Brushes.White, i, maxValue - array[i], 1, maxValue);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortEngine sortEngine = new BubbleSort();
            sortEngine.Sort(array, g, maxValue);
        }
    }
}
