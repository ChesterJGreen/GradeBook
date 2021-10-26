using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        private readonly BaseGradeBook ranked;
        public new string Name { get; set; }
        public new BaseGradeBook Type { get; set; }
        public RankedGradeBook(string name) : base(name)
        {
            Name = name;
            Type = ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            var AStudents = 0;
            var BStudents = 0;
            var CStudents = 0;
            var DStudents = 0;
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            var MaxStudentsPerSection = Students.Count / 5;
            List<Student> sortedStudentsByGrade = new List<Student>();
            sortedStudentsByGrade.Sort((x, y) => Student.AverageGrade);
            foreach (var )


            // var MaxGradeAverage = Student Student.AverageGrade.Max();
            // I'm trying to find the max and minimum values in the averageGrade column of the students class. to know where to define the sections at
            if (averageGrade >= 80 && AStudents < MaxStudentsPerSection)
            {
                AStudents++;
                return GetLetterGrade('A');
            }
            if (averageGrade >= 60 && averageGrade < 80 && BStudents < MaxStudentsPerSection)
            {
                BStudents++;
                return GetLetterGrade('B');
            }
            if (averageGrade >= 40 && averageGrade < 60 && CStudents < MaxStudentsPerSection)
            {
                CStudents++;
                return GetLetterGrade('C');
            }
            if (averageGrade >= 20 && averageGrade < 40 && DStudents < MaxStudentsPerSection)
            {
                DStudents++;
                return GetLetterGrade('D');
            }
            return GetLetterGrade('F');
        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
               Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            int isStudentGrades = 0;
               foreach (!Student.AverageGrade.Equals.null)
            {
                isStudentGrades++;
            }
               if (isStudentGrades <5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate at student's overall grade.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }
}
    
