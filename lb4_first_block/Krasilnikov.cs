using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4_krasilnikov_block1
{
    public partial class Krasilnikov
    {
        public static void ExtremeMinMax(ref int[] array)
        {

            if (array.Length != 0)
            {
                int min = array[0];
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }

                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }

                int[] newArr = new int[array.Length + 2];
                newArr[0] = min;

                for (int i = 0; i < array.Length; i++)
                {
                    newArr[i + 1] = array[i];
                }

                newArr[newArr.Length - 1] = max;


                array = newArr;
            }
            else
            {
                Console.WriteLine("Масив порожній, виконати дію неможливо...");
            }

		//something

//something one more
        }
    }
}
