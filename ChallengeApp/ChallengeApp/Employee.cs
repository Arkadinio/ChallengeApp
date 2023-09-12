﻿namespace ChallengeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {

            int valueInInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }

        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }

        }

        //int
        public void AddGrade(int grade)
        {
            int gradeToInt = (int)grade;
            this.AddGrade(gradeToInt);

        }

        //long
        public void AddGrade(long grade)
        {
            long gradeToLong = (long)grade;
            this.AddGrade(gradeToLong);

        }
        //double
        public void AddGrade(double grade)
        {
            float gradeToDouble = (float)grade;
            this.AddGrade(gradeToDouble);

        }

       

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;

            statistics.Max = float.MinValue;

            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
    }
}
