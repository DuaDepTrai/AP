using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250220.Assignment16
{
    public class SortByRank : IComparer
    {
        public int Compare(object x, object y)
        {
            Doctor d1 = (Doctor)x;
            Doctor d2 = (Doctor)y;
            return d1.getRank().CompareTo((int)d2.getRank());
        }
    }
}
