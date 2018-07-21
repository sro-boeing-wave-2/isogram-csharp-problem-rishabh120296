using System;
using System.Collections.Generic;
using System.Text;

namespace isogram
{
    public static class Class1
    {
        public static bool Convert(string inputString)
        {
            HashSet<char> isoString = new HashSet<char>();
            List<char> resultString = new List<char>();
            int pos = 0;
            foreach (char ele in inputString)
            {
                pos++;
                if ((ele >= 'A' && ele <= 'Z') || (ele >= 'a' && ele <= 'z'))
                {
                    resultString.Add(ele);
                    isoString.Add(ele);
                }
            }
            int count1 = resultString.Count;
            int count2 = isoString.Count;
            if (count1 == count2)
                return true;
            else
            {
                return false;
            }
        }
    }
}
