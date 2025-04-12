using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithm_Visualizer
{
    internal interface SortEngine
    {
        void Sort(int[] array, Graphics g, int maxValue);
    }
}
