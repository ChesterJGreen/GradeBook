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
            var FStudents = 0;
            var SectionOfStudents = 0;
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            var MaxStudentsPerSection = Students.Count / 5;
            if (Student student.AverageGrade.Equals > 80)



            
            if (averageGrade >= .8)
            {
                return GetLetterGrade('A');
            }
            else if(averageGrade >= .6 && averageGrade <.8)
            {
                return GetLetterGrade('B');
            }
            else if(averageGrade >= .4 && averageGrade <.6)
            {
                return GetLetterGrade('C');
            }
            else if(averageGrade >= .2 && averageGrade <.4)
            {
                return GetLetterGrade('D');
            }
           
            return base.GetLetterGrade('F');
        }
        

    }
}
    
