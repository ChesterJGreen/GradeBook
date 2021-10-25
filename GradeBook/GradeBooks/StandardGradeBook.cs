using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private readonly BaseGradeBook standard;

        public StandardGradeBook(string name, string type) : base(name)
        {
            Name = name;
            Type = standard;
        }

        public new string Name { get; set; }
        public new BaseGradeBook Type { get; set; }

        

        
    }
}
