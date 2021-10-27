﻿using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {


        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            IsWeighted = this.IsWeighted;
           Type = Enums.GradeBookType.Standard;
        }

       

        

        
    }
}
