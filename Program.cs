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
            }
            foreach (int value in myArr)
            {
                Console.WriteLine(value);
            }
        }
    }
}