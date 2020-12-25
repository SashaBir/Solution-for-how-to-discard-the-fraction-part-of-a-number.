using  System;
using System.Linq;

namespace ForGitHub
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float a = 5.454f;
            Console.WriteLine(a);
            a = GetShortNumber<float>(a, 2);
            Console.WriteLine(a);
        }
        
        private static T GetShortNumber<T>(dynamic anyNum, byte n = 0)
        {
            if (!(anyNum is float | anyNum is decimal | anyNum is double))
                throw new Exception("This is not the right type!");
            
            if (n == 0)
                return Convert.ToInt32(anyNum);

            long countZero = long.Parse(1.ToString().PadRight(n + 1, '0'));;
            
            anyNum = (long)(anyNum * countZero);
            anyNum = Convert.ChangeType(anyNum, typeof(T)) / countZero;

            return anyNum;
        }
    }
}