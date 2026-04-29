using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  
    class clsCalculator
    {
        private enum enOp { Initial, Adding, Subtracting, Multiplying, Dividing };
        private double _Result=0;
        private string  _clear;
        private enOp _y =enOp.Initial;
        private double _LastNumber;

        public void Add(double x) {
            _LastNumber=x;
            _y =enOp.Adding;
            _Result += x; 
        }
        public void Subtract(double x)
        {
            _LastNumber = x;
            _y = enOp.Subtracting;
            _Result -= x;
        }
        public void Multiply(double x)

        {
            _LastNumber = x;
            _y = enOp.Multiplying;
            _Result *= x;
        }
        public void Divide(double x)
        {
            _LastNumber = x;
            if (x == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return ;
            }
            _Result /= x;
            _y = enOp.Dividing;

        }
        public void Clear()
        {
            _LastNumber = 0;
            _Result = 0;

            _y = enOp.Initial;
        }
        public void PrintResult()
        {

            Console.WriteLine($"Result after { _y} {_LastNumber }:{_Result}");
            

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
 clsCalculator  calc1= new clsCalculator();
            calc1.Clear();
            calc1.Add(10);
            calc1.PrintResult();
            calc1.Multiply(3);
            calc1.PrintResult();
            calc1.Divide(2);
            calc1.PrintResult();
            calc1.Subtract(2);
            calc1.PrintResult();
            calc1.Clear();
            calc1.PrintResult();

        }
    }
}
