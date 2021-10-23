using System;
using System.Collections.Generic;
using System.Text;

namespace SortObject
{
    static class SortClass
    {
        public delegate int Compare(object obj1, object obg2);

        //Summary:
        //    Sorts objects array with bubble sort method
        public static void Sort(object[] obj, Compare compare)
        {
            if (obj == null)
                throw new ArgumentNullException("Object array cannot be null");

            for (int i = 0; i < obj.Length; i++)
                for (int j = 0; j < obj.Length - i - 1; j++)
                    if (compare(obj[j], obj[j + 1]) > 0)
                    {
                        object temp = obj[j];
                        obj[j] = obj[j + 1];
                        obj[j + 1] = temp;
                    }
        }
    }
}
