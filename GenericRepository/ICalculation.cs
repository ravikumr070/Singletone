using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public interface ICalculation<T,T1, T2,T3> where T : class
         where T1 : class
        where T2 : class
        where T3 : class
    {
        double Add(T data);
        double Subtract(T data);
        double Multiplie(T data);
        float Devide(T data);
        float Devide1(T1 data);
    }
}
