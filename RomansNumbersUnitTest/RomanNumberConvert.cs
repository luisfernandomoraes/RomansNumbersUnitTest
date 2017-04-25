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
            var acumulador = 0;
            var ultimoVizinhoDaDireita = 0;
            for (int i = romanNumber.Length - 1; i >= 0; i--)
            {
                // pega o inteiro referente ao simbolo atual
                var atual = _tableSimbols[romanNumber[i]];

                // se o da direita for menor, o multiplicaremos
                // por -1 para torná-lo negativo
                var multiplicador = 1;

                if (atual < ultimoVizinhoDaDireita)
                    multiplicador = -1;

                acumulador += atual * multiplicador;
                // atualiza o vizinho da direita
                ultimoVizinhoDaDireita = atual;
            }
            return acumulador;
        }
    }
}
