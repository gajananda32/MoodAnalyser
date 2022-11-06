﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUC5
{
    public class MoodAnalayserException:Exception 
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        //creating type variable for type exceptionType
        private readonly ExceptionType type;
        //parameterised constructor sets the expextion type and message
        //public MoodAnalayserException(ExceptionType Type , string message) : base(message)
        public MoodAnalayserException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
