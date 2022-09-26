using System.Text;

namespace Interview_Exercises
{
    public class FizzBuzz
    {

        //The function must implement a loop from 1 to the integer that was passed into the function.
        //For each iteration it will be determined if the number is a: 
        //“fizz” = the number is divisible by 3
        //“buzz” = the number is divisible by 5 
        //“fizzbuzz” = the number is divisible by both 5 and 3
        //"no-fizz-buzz" = specifications above not applicable 

        public List<FizzBuzzResult> Run(int number)
        {
            var fizzBuzzResults = new List<FizzBuzzResult>();

            //implementation

            return fizzBuzzResults;
        }

    }

    public class FizzBuzzResult
    {
        public int Number { get; set; }
        public string Description { get; set; }
    }
}