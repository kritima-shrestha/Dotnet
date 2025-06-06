﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_activity
{
    public class Inheritance
    {
        //Interface for addition operation
        interface IAddition
        {
            double Add(double a, double b);
        }

        //Interface for subtraction operation
        interface ISubtraction
        {
            double Subtract(double a, double b);
        }

        //Interface for multiplication operation
        interface IMultiplication
        {
            double Multiply(double a, double b);
        }

        //Interface for division operation
        interface IDivision
        {
            double Divide(double a, double b);
        }

        //Class implementing multiple mathematical operations
        public class MathOperation : IAddition, ISubtraction, IMultiplication, IDivision
        {
            public double Add(double a, double b)
            {
                return a + b;
            }

            public double Subtract(double a, double b)
            {
                return a - b;
            }
            public double Multiply(double a, double b)
            {
                return a * b;
            }
            public double Divide(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("cannot divide by zero.");
                }
                return a / b;
            }
        }
    }
}
