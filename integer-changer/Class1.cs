using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_changer
{
    class Class1
    {
        public static int ChangeMyIntA(int input)
        {
            return input + 3;
        }
        public static int ChangeMyIntB(int input)
        {
            return Convert.ToInt32(Math.Round(Math.Log10(Math.Pow(input + 3, 2))));
        }
        static int usageCounter = 1;
        public static int ChangeMyIntC(int input)
        {
            usageCounter--;
            if (usageCounter <= 0)
                usageCounter = 4;
            return input * (4 - usageCounter);
        }
    }
}
