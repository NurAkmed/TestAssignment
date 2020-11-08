using System.Collections.Generic;
using TestAssignment.Interface;

namespace TestAssignment.ResultClasses
{
    public class ResultArray
    {
        public string [] Results(int number)
        {
            List<IResult> fooBarObjects = new List<IResult>();
            fooBarObjects.Add(new ResultIfTwo());
            fooBarObjects.Add(new ResultIfThree());
            fooBarObjects.Add(new ResultIfFour());
            fooBarObjects.Add(new ResultIfFive());
            fooBarObjects.Add(new ResultIfSix());
            fooBarObjects.Add(new ResultIfSeven());
            fooBarObjects.Add(new ResultIfEight());
            fooBarObjects.Add(new ResultIfNine());
            string [] array = new string[fooBarObjects.Count];

            for (int i = 0; i < fooBarObjects.Count; i++)
            {
                array[i] = fooBarObjects[i].Result(number);
            }
            return array;
        }
    }
}