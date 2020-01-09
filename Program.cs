using System;
using System.Collections.Generic;
using GradeBook;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(34.2);
            book.AddGrade(11.1);
            book.AddGrade(1000.01);
            book.AddGrade(0.02);
            book.AddGrade(2000.0);
            book.ShowStatistics();            
        }
    }
}
