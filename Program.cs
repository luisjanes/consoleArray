using System.Runtime.InteropServices;

namespace consoleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var myArr = new int[5];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = i;
                Console.WriteLine(myArr[i]);
                if (i == 3)
                {
                    myArr[i] = 1995;
                }
            }
            foreach (int value in myArr)
            {
                Console.WriteLine(value);
            }
            var myNewArr = new int[5];
            myArr.CopyTo(myNewArr, 0);
            foreach (int value in myNewArr)
            {
                Console.WriteLine(value);
            }
        }
    }
}