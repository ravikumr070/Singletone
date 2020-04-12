using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public class Value {
        public int First { get; set; }
        public int Second { get; set; }
    }
    public class ValueC
    {
        public int First { get; set; }
        public int Second { get; set; }
    }
    public class ValueD
    {
        public int First { get; set; }
        public int Second { get; set; }
    }
    public class ValueB
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
    }
    public class Calculation : ICalculation<Value,ValueB, ValueC, ValueD>
    {
        public double Add(Value data)
        {
            var res = data.First + data.Second;
            return res;
        }

        public float Devide(Value data)
        {
            var res = data.First / data.Second;
            return res;
        }

        public float Devide1(ValueB data)
        {
            var res = data.First + data.Second;
            return res;
        }

        public double Multiplie(Value data)
        {
            var res = data.First * data.Second;
            return res;
        }

        public double Subtract(Value data)
        {
            var res = data.First- data.Second;
            return res;
        }
    }
}
