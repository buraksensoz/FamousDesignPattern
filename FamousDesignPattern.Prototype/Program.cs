using System;

namespace FamousDesignPattern.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mathExam1 = new Exam() { LessonCode = "Math01", LessonName = "Math", QuestionCount = 20 };
            var mathExam2 = mathExam1; //Same Stack Address 
            var mathExam3 = mathExam1.CloneExam(); // Clone Object Different Stack

            mathExam1.QuestionCount = 50;

            Console.WriteLine(mathExam2.QuestionCount + " From Exam2");
            Console.WriteLine(mathExam3.QuestionCount + " From Exam3 Clone Object (Prototype Design Pattern)");


        }


        public class Exam 
        {
            public string LessonCode { get; set; }
            public string LessonName { get; set; }
            public int QuestionCount{ get; set; }
            public Exam CloneExam()
            {
                return (Exam) this.MemberwiseClone();
            }
        }

    }
}
