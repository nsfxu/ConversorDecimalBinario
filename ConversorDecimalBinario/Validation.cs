using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDecimalBinario
{
    class Validation
    {
        public bool isNumber(string i)
        {
            int num = -1;
            if (int.TryParse(i, out num))
                return true;
            else
                return false;
        }

        public bool isMax(int i)
        {
            return i >= 65536;
        }

        public bool isNegative(int i)
        {
            return i < 0;
        }

        public bool isBMax(string i)
        {
            return i.Length > 16;
        }
    }
}
