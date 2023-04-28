using lb4_zaichyk_block1;
using lb4_popilevych_block1;
using lb4_krasilnikov_block1;
using System;
using System.Runtime.InteropServices;

namespace Lab4
{
    internal class example1
    {
        public static void Block_1()
        {
            Console.WriteLine("Введiть прiзвище студента, варiант якого хочете виконати. Для завершення виконання варiанту програми введiть 0. ");
            string choiceOfStudent = Console.ReadLine().ToLower();
            Console.Write("Введiть к-сть елементiв масиву: ");
            int countOfElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[countOfElements];
            Choose_The_Way_To_Fill(countOfElements, ref array);
            do
            {
                switch (choiceOfStudent)
                {
                    case "krasilnikov":
                        Krasilnikov.ExtremeMinMax(ref array);
                        Console.WriteLine("Результат:");
                        PrintArray(array);
                        break;
                    case "popilevych": 
                        Popilevych.DeleteOddElem(ref array);
                        Console.WriteLine("Результат:");
                        PrintArray(array);
                        break;
                    case "zaichuk":
                        Lilia.Block1(ref array);
                        Console.WriteLine("Результат:");
                        PrintArray(array);
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз");
                        break;
                }
                Console.WriteLine("Введiть прiзвище студента, варiант якого хочете виконати. Для завершення виконання варiанту програми введiть 0. ");
                choiceOfStudent = Console.ReadLine().ToLower();
                if (choiceOfStudent == "krasilnikov" || choiceOfStudent == "popilevych" || choiceOfStudent == "zaichuk")
                {
                    Console.WriteLine("Бажаєте створити новий масив?(Так/Нi)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "так")
                    {
                        Console.Write("Введiть к-сть елементiв: ");
                        countOfElements = Convert.ToInt32(Console.ReadLine());
                        array = new int[countOfElements];
                        Choose_The_Way_To_Fill(countOfElements, ref array);
                    }
                }
            } while (choiceOfStudent != "0");
        }

        public static void Main(string[] args)
        {
            Block_1();
        }
    }
}
