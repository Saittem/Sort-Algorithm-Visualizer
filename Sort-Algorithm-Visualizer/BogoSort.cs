using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualizer
{
    public class BogoSort
    {
        bool sorted = false;
        int[] array;
        Graphics g;
        int maxValue;
        float columnWidth;
        Brush WhiteBrush = new SolidBrush(Color.White);
        Brush BlackBrush = new SolidBrush(Color.Black);

        public bool Sort(int[] array_lc, Graphics g_lc, int maxValue_lc, float columnWidth_lc)
        {
            array = array_lc;
            g = g_lc;
            maxValue = maxValue_lc;
            columnWidth = columnWidth_lc;

            while (!sorted)
            {
                Shuffle(array);

                sorted = IsSorted();
            }

            return sorted;
        }

        private void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length - 1; ++i)
            {

            }

            int r = random.Next(0, array.Length);
            int v = random.Next(0, array.Length);
            (array[r], array[v]) = (array[v], array[r]);

            g.FillRectangle(BlackBrush, r * columnWidth, 0, columnWidth, maxValue);
            g.FillRectangle(BlackBrush, v * columnWidth, 0, columnWidth, maxValue);

            g.FillRectangle(WhiteBrush, r * columnWidth, maxValue - array[r], columnWidth - 1, maxValue);
            g.FillRectangle(WhiteBrush, v * columnWidth, maxValue - array[v], columnWidth - 1, maxValue);
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
