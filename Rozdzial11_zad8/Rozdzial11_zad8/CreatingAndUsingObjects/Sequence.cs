using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdzial11_zad8.CreatingAndUsingObjects
{
    class Sequence
    {
        private static int currentValue = 0;

        private Sequence()
        {
        }

        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
