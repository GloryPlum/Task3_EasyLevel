using System;

namespace Проект_Easy_Level
{
    class Program
    {
        static Random rnd = new Random();
        static int[] arr = new int[rnd.Next(1, 104)];
        static int index = -1;
        static void Main(string[] args)
        {
            for (int i = 0;i<arr.Length;i++)
            {
                int rn = rnd.Next(-104, 104);
                while (Prov(rn)==true)
                {
                    rn = rnd.Next(-104, 104);
                }
                arr[i] = rn;    
            }
            Sort(arr);
            Outputarr(arr);
            Console.WriteLine();

            int tar = rnd.Next(-104,104);

            Console.WriteLine("Искомое число: "+tar);

            for (int i = 0; index == -1; i++)
            {
                if (arr[i] == tar)
                {
                    index = i;
                }
                else
                {
                    int k = i;
                    if ((i == (arr.Length - 1)) && (arr[i] < tar))
                    {
                        index = i + 1;
                    }
                    else
                    {
                        if (arr[i] > tar)
                        {
                            if (i == 0)
                            {
                                index = 0;
                            }
                            else
                            {
                                for (int j = k; index == -1; j--)
                                {
                                    if (arr[j] < tar)
                                    {
                                        index = j + 1;
                                    }
                                }
                            }
                        }

                    }
                }


            }
            Console.WriteLine("Индекс " + index);



        }
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int m = array[i];
                        array[i] = array[j];
                        array[j] = m;
                    }

                }
            }
            return (array);


        }
        public static void Outputarr(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static bool Prov(int ch)
        {
            bool pr = false;
            for (int i=0;i<arr.Length;i++)
            {
                if (ch == arr.Length)
                    pr = true;
            }
            return (pr);
        }
    } 
}
