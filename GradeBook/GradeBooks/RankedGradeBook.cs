using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            
           
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            var MaxStudentsPerSection = Students.Count / 5;

            var grades = this.Students.Select(s => s.AverageGrade).ToList();
            // grades = 90, 80, 80, 75, 73
            // avg = 75
            // indexOf = 3
            // if we add 75 to the list, -> 90, 80, 80, 75, 75, 73
            // ... indexOf = 3
            grades.Add(averageGrade);
            grades.Sort();
            grades.Reverse(); // highest grade at top (index = 0)

            int studentsWhoDidBetterThanInput = grades.IndexOf(averageGrade);

            if (studentsWhoDidBetterThanInput == -1)
            {
                throw new ArgumentException();
            }

            int sectionsUnderTop = studentsWhoDidBetterThanInput / MaxStudentsPerSection;

            switch (sectionsUnderTop)
            {
                case 0:
                    return 'A';
                case 1: 
                    return 'B';
                case 2:
                    return 'C';
                case 3:
                    return 'D';
                case 4:
                    return 'F';
                default:
                    throw new IndexOutOfRangeException();
            }
            /*
            List<Student> sortedStudentsByGrade = new List<Student>();
            sortedStudentsByGrade.AddRange(this.Students);
            sortedStudentsByGrade.Sort((x, y) => x.AverageGrade.CompareTo(y.AverageGrade));
           
            // determine where the input average grade would fall in the sorted list (aka: how many students did better than the iput)
            

            // var MaxGradeAverage = Student Student.AverageGrade.Max();
            // I'm trying to find the max and minimum values in the averageGrade column of the students class. to know where to define the sections at
            if (sortedStudentsByGrade >= 80 && AStudents < MaxStudentsPerSection)
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
            return GetLetterGrade('F');*/
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
            int isStudentGrades = this.Students.Count(student => student.AverageGrade != null);

               if (isStudentGrades <5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate at student's overall grade.");
                return;
            }

            base.CalculateStudentStatistics(name);
        }
    }
}
    
