using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortUtils
{
    public class TypeComparators
    {
        public static int IntComparatorAscending(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (b > a)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        //public static int IntComparatorDescending(int a, int b)
        //{
        //    if (a > b)
        //    {
        //        return -1;
        //    }
        //    else if (b > a)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }

        //}



    }
}
