using FluentAssertions;
using Interview_Exercises;

namespace Testing_Interview_Exercises
{
    public class TestingFizzBuzz
    {

        [Fact]
        public void NoFizzOrBuzz()
        {
            //arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            var result = fizzBuzz.Run(2);

            //assert
            result[0].Should().BeEquivalentTo(new FizzBuzzResult { Number = 1, Description = "no-fizz-buzz" });
            result[1].Should().BeEquivalentTo(new FizzBuzzResult { Number = 2, Description = "no-fizz-buzz" });
        }

        [Fact]
        public void Fizz()
        {
            //arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            var result = fizzBuzz.Run(3);

            //assert
            result[0].Should().BeEquivalentTo(new FizzBuzzResult { Number = 1, Description = "no-fizz-buzz" });
            result[1].Should().BeEquivalentTo(new FizzBuzzResult { Number = 2, Description = "no-fizz-buzz" });
            result[2].Should().BeEquivalentTo(new FizzBuzzResult { Number = 3, Description = "fizz" });
        }

        [Fact]
        public void Buzz()
        {
            //arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            var result = fizzBuzz.Run(6);

            //assert
            result[0].Should().BeEquivalentTo(new FizzBuzzResult { Number = 1, Description = "no-fizz-buzz" });
            result[1].Should().BeEquivalentTo(new FizzBuzzResult { Number = 2, Description = "no-fizz-buzz" });
            result[2].Should().BeEquivalentTo(new FizzBuzzResult { Number = 3, Description = "fizz" });
            result[3].Should().BeEquivalentTo(new FizzBuzzResult { Number = 4, Description = "no-fizz-buzz" });
            result[4].Should().BeEquivalentTo(new FizzBuzzResult { Number = 5, Description = "buzz" });
        }

        [Fact]
        public void FizzOrBuzz()
        {
            //arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            var result = fizzBuzz.Run(15);

            //assert
            result[0].Should().BeEquivalentTo(new FizzBuzzResult { Number = 1, Description = "no-fizz-buzz" });
            result[1].Should().BeEquivalentTo(new FizzBuzzResult { Number = 2, Description = "no-fizz-buzz" });
            result[2].Should().BeEquivalentTo(new FizzBuzzResult { Number = 3, Description = "fizz" });
            result[3].Should().BeEquivalentTo(new FizzBuzzResult { Number = 4, Description = "no-fizz-buzz" });
            result[4].Should().BeEquivalentTo(new FizzBuzzResult { Number = 5, Description = "buzz" });
            result[5].Should().BeEquivalentTo(new FizzBuzzResult { Number = 6, Description = "fizz" });
            result[6].Should().BeEquivalentTo(new FizzBuzzResult { Number = 7, Description = "no-fizz-buzz" });
            result[7].Should().BeEquivalentTo(new FizzBuzzResult { Number = 8, Description = "no-fizz-buzz" });
            result[8].Should().BeEquivalentTo(new FizzBuzzResult { Number = 9, Description = "fizz" });
            result[9].Should().BeEquivalentTo(new FizzBuzzResult { Number = 10, Description = "buzz" });
            result[10].Should().BeEquivalentTo(new FizzBuzzResult { Number = 11, Description = "no-fizz-buzz" });
            result[11].Should().BeEquivalentTo(new FizzBuzzResult { Number = 12, Description = "fizz" });
            result[12].Should().BeEquivalentTo(new FizzBuzzResult { Number = 13, Description = "no-fizz-buzz" });
            result[13].Should().BeEquivalentTo(new FizzBuzzResult { Number = 14, Description = "no-fizz-buzz" });
            result[14].Should().BeEquivalentTo(new FizzBuzzResult { Number = 15, Description = "fizzbuzz" });
        }
    }
}