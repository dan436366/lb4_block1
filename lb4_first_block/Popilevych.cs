using System;

namespace lb4_popilevych_block1
{
    public partial class Popilevych 
    {
        public static void DeleteOddElem(ref int[] array)
        {
            int[] newArray = new int[array.Length];
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2!=0)
                {
                    newArray[cnt] = array[i];
                    cnt++;
                }
            }
            Array.Resize(ref newArray, cnt);
            array = newArray;
        }
    }
}
