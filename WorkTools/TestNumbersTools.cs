using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTools
{
    public class TestNumbersTools
    {
        /*
            Problema: Uma determinada indústria tem uma lista de quantidade de produtos produzidos por lote. Como esses produtos são vendidos em pares, a indústria precisa identificar a quantidade de lotes prontos para venda, ou seja, vamos construir uma função que conta e retorna a quantidade de número pares dentro de um array de números inteiros.
            */
        public static int CountEvenNumbers(int[] numbers)
        {
            var count = 0;

            foreach (var number in numbers)
            {
                if (number % 2 != 0) continue;
                count++;
            }
            return count;
        }
    }
}