using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static int m;
        static void Main(string[] args)
        {
            user use = new user();
            try
            {
                use.X = '%';
            }
            catch
            {
                Console.WriteLine("输入的除法运算符有误，应为‘/’");
            }
            calculator cal = new calculator();
            Console.Write("要进行什么运算：1、整数加减乘除，2、字符串的运算");
            m = int.Parse(Console.ReadLine());
            if(m==1)
            {
                use.input();
                switch (use.X)
                {
                    case '+': Console.WriteLine("{0}", use.A + "+" + use.B + "=" + cal.add(use.A, use.B)); break;
                    case '-': Console.WriteLine("{0}", use.A + "-" + use.B + "=" + cal.Subtract(use.A, use.B)); break;
                    case '*': Console.WriteLine("{0}", use.A + "*" + use.B + "=" + cal.multiplication(use.A, use.B)); break;
                    case '/': Console.WriteLine("{0}", use.A + "/" + use.B + "=" + cal.division(use.A, use.B)); break;
                    default: Console.WriteLine("计算机中无次运算符"); break;
                }
                Equals(use);
            }
            else
            {
                use.sinput();
                switch(use.X)
                {
                    case '+': Console.WriteLine("{0}",cal.add(use.Xx, use.Yy)); break;
                    case '-': Console.WriteLine("{0}", cal.Subtract(use.Xx, use.Yy)); break;
                    default: Console.WriteLine("计算机中无次运算符"); break;
                }
            }
            
           
          
        }
        public static void Equals(user use)
        {
            if (use.A == use.B)
                Console.WriteLine("两个整数相等");
            else
            {
                Console.WriteLine("两个整数不相等");
            }
        }
            
        }
    }
