using System.Collections.Generic;
using TestAssignment.Interface;

namespace TestAssignment.ResultClasses
{
    public class ResultArray
    {
        public string [] Results(int number)
        {
            List<IResult> results = new List<IResult>()
            {
                new ResultIfTwo(),
                new ResultIfThree(),
                new ResultIfFour(),
                new ResultIfFive(),
                new ResultIfSix(),
                new ResultIfSeven(),
                new ResultIfEight(),
                new ResultIfNine()
            };
            string [] array = new string[results.Count];

            for (int i = 0; i < results.Count; i++)
            {
                array[i] = results[i].Result(number);
            }
            return array;
        }
    }
}