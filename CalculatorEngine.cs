﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            switch(argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber + argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified opreration is not recognized.");
            }

            return result;
        }
    }
}
