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

        public bool Sort(int[] array_lc, Graphics g_lc, int maxValue_lc)
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
                    //Console.Beep(array[i] * 100, 1);
                }
                sorted = IsSorted();
            }

            return sorted;
        }

        private void Swap(int i, int v)
        {
            int temp  = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;

            g.FillRectangle(BlackBrush, i * array.Length, 0, array.Length, maxValue);
            g.FillRectangle(BlackBrush, v * array.Length, 0, 1, maxValue);

            g.FillRectangle(WhiteBrush, i * array.Length, maxValue - array[i], array.Length, maxValue);
            g.FillRectangle(WhiteBrush, v * array.Length, maxValue - array[v], array.Length, maxValue);
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
