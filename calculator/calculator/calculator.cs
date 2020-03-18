using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace calculator
{
    class calculator
    {
        //运算结果
        int sum;
        string ss;
        public int add(int a,int b)
        {
            sum = a + b;
            return sum;
        }
        public string add(string xx,string yy)
        {
            ss = string.Join(" ",xx, yy);
            return ss;
        }
        public int Subtract(int a,int b)
        {
            sum = a - b;
            return sum;
        }
        public string Subtract(string xx, string yy)
        {
            Regex r = new Regex(yy);
            ss = r.Replace(xx, "");
            return ss;
        }
        public int multiplication(int a,int b)
        {
            sum = a * b;
            return sum;
        }
        public int division(int a,int b)
        {
            sum = a / b;
            return sum;
        }
    }
}
