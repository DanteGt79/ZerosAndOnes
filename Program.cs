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

            //const, it could be replaced by an user input
            const int number = 9;
            //local variables
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
                        //if the array contains at least one ocurrence of digits different from 1 or 0, we stopped the search
                        isZerosAndOnes = false;
                    }
                    j++; //next element in the char array
                } while (j < array.Length && isZerosAndOnes);

            } while (!isZerosAndOnes);

            //output
            Console.WriteLine("The number {0}, is {1} times {2}, and it only contains 1 & 0s", multiple, i, number);
            Console.ReadLine();

        }
    }
}
