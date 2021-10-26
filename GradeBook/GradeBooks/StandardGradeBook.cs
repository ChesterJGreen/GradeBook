using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {


        public StandardGradeBook(string name) : base(name, isWeighted)
        {
            IsWeighted = this.Student.IsWeighted;
           Type = Enums.GradeBookType.Standard;
        }

       

        

        
    }
}
