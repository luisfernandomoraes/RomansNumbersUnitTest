using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomansNumbersUnitTest
{
    public class RomanNumberConvert
    {
        private static Dictionary<char,int> _tableSimbols =
            new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int Convert(string romanNumber)
        {
            int acumulador = 0;
            for (int i = 0; i < romanNumber.Length; i++)
            {
                acumulador += _tableSimbols[romanNumber[i]];
            }
            return acumulador;
        }
    }
}
