using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Complex
    {
        private double sb;
        private double xb;
        public Complex(double sb, double xb)
        {//定义新数据类型复数
            this.sb = sb;
            this.xb = xb;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            double x = a.sb + b.sb;
            double y = a.xb + b.xb;
            Complex result = new Complex(x, y);
            return result;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            double x = a.sb - b.sb;
            double y = a.xb - b.xb;
            Complex result = new Complex(x, y);
            return result;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            
            double x = a.sb * b.sb - a.xb * b.xb;
            double y = a.sb * b.xb + a.xb * b.sb;
            Complex result = new Complex(x,y);
            return result;
        }
        public static Complex operator /(Complex a, Complex b)
        {//分母实数化
            
            double m = b.sb;
            double n = -b.xb;
            Complex temp = new Complex(m, n);
            double x=0, y=0;
            Complex result = new Complex(x,y);
            result = a * temp;//分子计算调用复数乘法运算方法
            x = x / (b.sb * b.sb + b.xb * b.xb);
            y = y / (b.sb * b.sb + b.xb * b.xb);
            return result;
        }
        public static int Pl(int m, int n)
        {//即计算排列数A(m,n)的结果
            int s = 1;
            for (int i = 0; i < n; i++)
                s *= (m - i);
            return s;
        }
        public static int zh(int m, int n)
        {//即计算组合数C(m,n)的结果
            return Pl(m, n) / Pl(n, n);
        }
        public static Complex Pow(Complex a, int b)
        {//请输入正整数b
            double x=0, y=0;
            if (b == 1)
                return a;
            else
            {//利用二项式定理完成计算
                for (int i = 0; i <= b; i++)
                {
                    double temp = zh(b, i) * Math.Pow(a.sb , (double)(b - i) * Math.Pow(a.xb , (double)i) * Math.Pow((-1) , (i / 2)));
                    if (i % 2 == 0)
                        x += temp;
                    else
                        y += temp;
                }
                Complex result = new Complex(x, y);
                return result;
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
