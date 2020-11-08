using System;
using TestAssignment.Interface;

namespace TestAssignment.ResultClasses
{
    
    public class ResultIfTwo : IResult
    {
        public string Result(int number)
        {
            int result = number % 2;
            string res = String.Empty;
            if(result == 0)
              res = "tar";
            return res;
        }
    }
    public class ResultIfThree : IResult
    {
        public string Result(int number)
        {
            int result = number % 3;
            string res = String.Empty;
            if(result == 0)
             res = "foo";
            return res;
        }
    }
    public class ResultIfFour : IResult
    {
        public string Result(int number)
        {
            int result = number % 4;
            string res = String.Empty;
            if(result == 0)
             res = "moo";
            return res;
        }
    }
    public class ResultIfFive : IResult
    {
        public string Result(int number)
        {
            int result = number % 5;
            string res = String.Empty;
            if(result == 0)
             res = "bar";
            return res;
        }
    }
    public class ResultIfSix : IResult
    {
        public string Result(int number)
        {
            int result = number % 6;
            string res = String.Empty;
            if(result == 0)
             res = "hoo";
            return res;
        }
    }
    public class ResultIfSeven : IResult
    {
        public string Result(int number)
        {
            int result = number % 7;
            string res = String.Empty;
            if(result == 0)
             res = "boo";
            return res;
        }
    }
    public class ResultIfEight : IResult
    {
        public string Result(int number)
        {
            int result = number % 8;
            string res = String.Empty;
            if(result == 0)
             res = "nar";
            return res;
        }
    }
    public class ResultIfNine : IResult
    {
        public string Result(int number)
        {
            int result = number % 9;
            string res = String.Empty;
            if(result == 0)
             res = "koo";
            return res;
        }
    }
}