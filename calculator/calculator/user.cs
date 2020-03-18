using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class user
    {
        //两个整数
        private int b;
        private int a;
        //两个字符串
        string xx;
        string yy;

        //运算符
        char x;

        public int A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public char X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public string Yy
        {
            get
            {
                return yy;
            }

            set
            {
                yy = value;
            }
        }

        public string Xx
        {
            get
            {
                return xx;
            }

            set
            {
                xx = value;
            }
        }

        public void input()
        {
            Console.Write("输入要运算的第一个整数：");
            A = int.Parse(Console.ReadLine());
            Console.Write("输入要运算的第二个整数：");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("输入要进行的操作");
            X = char.Parse(Console.ReadLine());
            
        }
       
      public void sinput()
        {
            Console.Write("输入要运算的第一个字符串：");
            xx = Console.ReadLine();
            Console.WriteLine("输入要进行的操作");
            X = char.Parse(Console.ReadLine());
            Console.WriteLine("输入要运算的第二个字符串：");
            yy= Console.ReadLine();

        }
    }
}
