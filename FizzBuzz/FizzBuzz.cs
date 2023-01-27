using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public static List<string> ToStringsFizzBuzz(List<int> numbers)
        {
            var strings = new List<string>();
            foreach (var num in numbers)
            {
                var addString = num switch
                {
                    var value when value % 15 == 0 => "FizzBuzz",
                    var value when value % 3 == 0 => "Fizz",
                    var value when value % 5 == 0 => "Buzz",
                    _ => num.ToString()
                };
                strings.Add(addString);
            }

            return strings;
        }
    }
}