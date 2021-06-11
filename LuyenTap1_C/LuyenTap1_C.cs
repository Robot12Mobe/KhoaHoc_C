using System;

namespace LuyenTap1_C
{
    class LuyenTap1_C
    {
        static void Main()
        {
            Console.Write("Nhap N: ");
            string _str_N = Console.ReadLine();
            int _int_N = Convert.ToInt32(_str_N);
            int N = _int_N * _int_N * _int_N;
            int i = 0;
            int S = 0;
            while (i <= N)
            {
                S += i * i * i;
                i = i + 1;
                Console.WriteLine("S = {0}", S);
                Console.ReadLine();
            }
        }
    }
}
