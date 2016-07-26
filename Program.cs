using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneAndZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 9;
            var i = 1;
            int multiple;
            bool isZerosAndOnes;
            char[] array;

            do
            {
                i++;
                multiple = number*i;
                isZerosAndOnes = true;

                array = multiple.ToString(CultureInfo.InvariantCulture).ToCharArray();

                int j = 0;
                do
                {
                    if ((!array[j].Equals('1') && !array[j].Equals('0')))
                    {
                        isZerosAndOnes = false;
                    }
                    j++;
                } while (j < array.Length && isZerosAndOnes);

            } while (!isZerosAndOnes);


            Console.WriteLine("The number {0}, is {1} times {2}, and it only contains 1 & 0s", multiple, i, number);
            Console.ReadLine();

        }
    }
}
