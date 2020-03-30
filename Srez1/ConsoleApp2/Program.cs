using System;
using System.Text;
using System.IO;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string argz;
            Console.WriteLine("Способ ввода консоль, или файл(с/f)");
            char chois = Convert.ToChar(Console.ReadLine());
            if(chois == 'c')
            {
                console(out argz);
                schet(argz);
            }
            if (chois == 'f')
            {
                file(out argz);
                schet(argz);
            }


        }

        static void console(out string argz)
        {
            Console.WriteLine("Введите ваши данные");
            string arg = Console.ReadLine();
            argz = null;
            argz = arg;
            
           
        }

        static void file(out string argz)
        {
            StreamReader read = new StreamReader("Input.in");
            string arg = read.ReadLine();
            argz = null;
            argz = arg;
            read.Close();
        }

        static void schet(string argz)
        {
            
            while (argz.Contains("  "))
            {
                argz = argz.Replace("  ", " ");

            }
            string[] arr = argz.Split(' ');

            StringBuilder sb = new StringBuilder(arr.Length);
            foreach (string ch in arr)
            {
                sb.Append(ch);
                sb.Append(',');
            }
            string value = sb.ToString();
            

            while (value.Contains(",,"))
            {
                value = value.Replace(",,", ",");

            }
            
            arr = value.Split(',');
            for (int j = 0; j + 1 < arr.Length; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("X: " + arr[j] + " ");
                }
                else if (j % 2 != 0)
                {
                    Console.Write("Y: " + arr[j] + " ");
                }
            }
        }
    }
}
