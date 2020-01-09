using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
       public void AddGrade(double grade)
       {
           grades.Add(grade);
       }
       public double GetAverage()
        {
            var result = 0.0;
            var total = 0.0;
            foreach(var number in grades)
            {
                total += number;
            }

            result = total / grades.Count;
            return result;
        }

        private double GetMax()
        {
            var result = double.MinValue;
            foreach(var number in grades)
            {
                result = Math.Max(number, result);
            }
            return result;
        }

        private double GetMin()
        {
            var result = double.MaxValue;
            foreach(var number in grades)
            {
                result = Math.Min(number, result);
            }
            return result;
        }
        public void ShowStatistics()
        {
            Console.WriteLine($"Minimum: {GetMin():N2}");
            Console.WriteLine($"Maximum: {GetMax():N2}");
            Console.WriteLine($"Average: {GetAverage():N2}");
        }
       List<double> grades; 
    }
}