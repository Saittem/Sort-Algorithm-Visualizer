using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualizer
{
    public class BubbleSort : SortEngine
    {
        bool sorted = false;
        int[] array;
        Graphics g;
        int maxValue;
        Brush WhiteBrush = new SolidBrush(Color.White);
        Brush BlackBrush = new SolidBrush(Color.Black);
        public void Sort(int[] array_lc, Graphics g_lc, int maxValue_lc)
        {
            array = array_lc;
            g = g_lc;
            maxValue = maxValue_lc;

            while (!sorted)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(i, i + 1);
                    }
                }
                sorted = IsSorted();
            }

        }

        private void Swap(int i, int v)
        {
            int temp  = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;

            g.FillRectangle(BlackBrush, i, 0, 1, maxValue);
            g.FillRectangle(BlackBrush, v, 0, 1, maxValue);

            g.FillRectangle(WhiteBrush, i, maxValue - array[i], 1, maxValue);
            g.FillRectangle(WhiteBrush, v, maxValue - array[v], i, maxValue);
        }

        private bool IsSorted()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }
            return true;
        }
    }
}
