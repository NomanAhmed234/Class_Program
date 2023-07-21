using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5q2
{
    internal class student
    {
        public string name;
        public int age;
        public int engMarks;
        public int sciMarks;
        public int mathsMarks;
        public int totalMarks = 300;
        public float obtainMarks;
        public float percentage;
        public void calculateTotalMarks()
        {
            Console.WriteLine("Enter Your Name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter English Marks: ");
            this.engMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks: ");
            this.mathsMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Science Marks: ");
            this.sciMarks = Convert.ToInt32(Console.ReadLine());
            this.obtainMarks = this.engMarks + sciMarks + mathsMarks;
            Console.WriteLine("You Have Obtained {0} Marks out of 300.",obtainMarks);
        }

        public void calculatePercentage()
        {
            this.percentage = obtainMarks / totalMarks * 100;
            Console.WriteLine("You got {0}%.",percentage);
        }
    }
}
