using System;
using System.Text.RegularExpressions;

namespace RepeatNumericValidator
{
    class Program
    {
        /*
         * 參考網址
         * https://stackoverflow.com/questions/2823016/regular-expression-for-consecutive-duplicate-words 
         * 
         * 驗證工具可參考
         * https://regexr.com/
         */
        static void Main(string[] args)
        {
            /* 
             * 使用逗號分隔數字 
             *  若有重複的話就驗證失敗
             */

            var _pattern = @"(\b\S+\b)(($|\,+)\1)+";

            var _inputs = new string[] {
                "1,25,33,6" ,
                "1,33,33,6" ,
                "100,100,14,7,8,9" , 
                "-1,1,1,1,8,5"
            };

            var _regex = new Regex(_pattern);
            var _isMatch = false;

            Console.WriteLine("regex pattern: \"{0}\"", _pattern);
            Console.WriteLine();

            foreach (var _input in _inputs)
            {
                _isMatch = _regex.IsMatch(_input);

                Console.WriteLine("input: \"{0}\"", _input);
                Console.WriteLine("is Match: {0}", _isMatch);
                Console.WriteLine();
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
