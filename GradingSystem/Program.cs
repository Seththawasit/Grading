using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            Grading.GradeCalculator(score);
        }
    }
}