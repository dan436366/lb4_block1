using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4_zaichyk_block1
{
    public partial class Lilia
    {
        //Знищити T елементів, починаючи з номеру К(лише якщо всі такі елементи фактично є в масиві)
        public static void Block1(ref int[] array)
        {
            Console.WriteLine("Введіть кількість елементів, які потрібно знищити:");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть починаючи з якого номеру знищити елементи:");
            int k = int.Parse(Console.ReadLine());

            if (array == null || t < 0 || k < 0 || t + k > array.Length)
            {
                Console.WriteLine("Видалити неможливо, " +
                "iндекс поза допустимими межами");
            }
            else
            {
                int[] new_arr = new int[array.Length - t];
                for (int i = 0; i < k; i++)
                {
                    new_arr[i] = array[i];
                }
                for (int i = k; i < new_arr.Length; i++)
                {
                    new_arr[i] = array[i + t];
                }
                array = new_arr;

            }//фыв

        }
    }
}
