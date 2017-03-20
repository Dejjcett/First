using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 0; i<30 ; i++)//多次输出，不跳出程序
            {
                Random ran = new Random(); 
                int num1 = ran.Next(1, 999);
                int num2 = ran.Next(1, 999);//生成1-999之间的随机数字

                string str = @"+-*/";
                Random rp = new Random();
                string c = str.Substring(rp.Next(4), 1);//生成+-*/随机字符，可随着要求改变
                Console.WriteLine(num1 + c + num2 + "=");
             //   Console.ReadKey();
         }

        }
    }
}
