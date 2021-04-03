using System;

namespace HomeWork
{
    class Calculator
    {
        public enum Operations{Add = 1 , Substraction, Mult, Div};
        private Operations operation;
        private Func<double> func;
        public void SetOperation(Operations operation) {
            this.operation = operation;
            
        }
        public double Calculate(double num, double num2) {
            if ((int)operation == 1)
            {
                func = () => { return num + num2; };
            }
            else if ((int)operation == 2)
            {
                func = () => { return num - num2; };
            }
            else if ((int)operation == 3)
            {
                func = () => { return num * num2; };
            }
            else {
                if (num2 == 0 )
                {
                    throw new Exception("Denom is 0");
                }
                func = () => { return num / num2; };
            }
            return func.Invoke();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.SetOperation(Calculator.Operations.Mult);
            Console.WriteLine(calc.Calculate(2,5));
        }
    }
}
