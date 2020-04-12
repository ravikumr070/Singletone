using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

            var obj = SingleTone.SingleTone_Instance();
            var obj1 = SingleTone.SingleTone_Instance();
            var obj2 = SingleTone.SingleTone_Instance();
            if (obj == obj1 && obj == obj2)
            {
                Console.WriteLine("Same Object");
            }
            
            CallaA A = new CallaA();
            var aaaa = A.Add(1);
            //var aa= obj.Add(1);
            //Console.WriteLine("Singletone Object"+aa.ToString());

        }
    }
    public sealed class SingleTone
    {

        private static SingleTone instance;
        private static object inst = new object();

        private SingleTone()
        {

        }
        public static SingleTone SingleTone_Instance()
        {
            if (instance == null)
            {
                lock (inst)
                {
                    instance = new SingleTone();
                    return instance;
                }
            }
            else
            {
                return instance;
            }
        }
        public int Add(int a)
        {
            return a;
        }
    }
    public class CallaA
    {


        public int Add(int a)
        {
            return a;
        }
    }
}
