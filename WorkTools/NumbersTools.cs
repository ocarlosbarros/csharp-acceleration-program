using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTools
{
    public class NumbersTools
    {
        /*
            Problema: Uma rede de supermercado precisa saber, dentro de uma lista de produtos vendidos no mês, quantas vezes um determinado produto foi vendido, ou seja, a quantidade de vezes que um determinado número aparece em uma coleção de outros números. Para isso, vamos precisar percorrer todos os elementos dessa coleção comparando com o número que estamos procurando.
            */
        public static int CountOf(int[] numbers, int value)
        {
            var count = 0;
            foreach (var number in numbers)
            {   
                if (number == value) count++;
            }

            return count;
        }

        /*
            Problema: Como uma pessoa programadora, você foi contratada por uma empresa de produtos eletrônicos para construir uma função que identifique a posição de vendas de um determinado produto em um ranking de produtos vendidos. Você precisará construir uma função que retorna a posição que um valor está dentro de um array ou retornará -1 quando não encontrar.
            */
        public static int IndexOf(int[] numbers, int value)
        {
            var position = -1;

            for (int i = 0; i < numbers.Count(); i++)
            {
                if  (numbers[i] == value)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
    }
}