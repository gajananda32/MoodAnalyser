using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUC5
{
    public class MoodAnalyserFactory
    {
        public static object MoodAnalyserUsing_Parameterised_Constructor(string className,string constructorName)
        {
            Type type = typeof(Mood);
            if (type.Name.Equals(className) || type.Name.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalayserException(MoodAnalayserException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new MoodAnalayserException(MoodAnalayserException.ExceptionType.NO_SUCH_CLASS, "class not found");
            }
        }
    }
}
