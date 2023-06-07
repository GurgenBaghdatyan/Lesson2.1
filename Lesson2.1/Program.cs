using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c= ");
            c = Convert.ToInt32(Console.ReadLine());
            //1
            if (a > b && a > c )
            {
                Console.WriteLine("a is biggest");
            }
            else if (b > c)
            {
                Console.WriteLine("b is biggest");
            }
            
            else { Console.WriteLine("c is biggest"); }
            //2
            if (a < b && a < c )
            {
                Console.WriteLine("a is smallest");
            }
            else if (b < c )
            {
                Console.WriteLine("b is smallest");
            }
            else { Console.WriteLine("c is smallest"); }
            //3
            if (a == 1 || b == 1 || c == 1 )
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            //4
            if ((a==2&& b==2)|| (a == 2 && c == 2)|| (c == 2 && b == 2))
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");
            //5
            if (a+b>c||a+c==b||c+b==a)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            //6
            if (a%2==0||b%2==0||c%2==0)
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            //7
            if (a - b == b - c|| b - a == a - c|| a - c == c - b) Console.WriteLine("true");
            else Console.WriteLine("false");
            //8
            if (a / b == b / c || b / a == a / c|| a - c == c - b) Console.WriteLine("true");
            else Console.WriteLine("false");
            //9
            int k;
            if(a<b)
            {
                k=a;
                a=b;   
                b=k;
            }
            if (b<c)
            {
                k=b;
                b=c;
                c = k;
            }
            if  (a<b)
            {
                k=a;
                a=c; 
                c=k;
            }
            Console.WriteLine(a+" "+b+" "+ c);
            if (a > b)
            {
                k = a;
                a = b;
                b = k;
            }
            if (b > c)
            {
                k = b;
                b = c;
                c = k;
            }
            if (a > b)
            {
                k = a;
                a = b; 
                b = k;
            }
            Console.WriteLine(a + " " + b + " " + c);



            Console.ReadKey();
        }
    }
}
