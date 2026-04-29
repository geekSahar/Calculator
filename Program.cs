using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class clsCalculator
    {
        private int _Result=0;
        private string _y ="";
        public void Add(int x) {
            _y=$"Result after adding {x}:";
            _Result += x; 
        }
        public void Subtract(int x)
        {
            _y = $"Result after subtracting {x}:";
            _Result -= x;
        }
        public void Multiply(int x)
        {
            _y = $"Result after Multplying {x}:";
            _Result *= x;
        }
        public void Divide(int x)
        {
           
            if (x == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return ;
            }
            _Result /= x;
            _y = $"Result after dividing {x}: ";

        }
        public void Clear()
        {

            _Result = 0;
            _y = $"Result cleared ";

        }
        public void PrintResult()
        {

            Console.WriteLine($"{ _y}{_Result}");
            

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
