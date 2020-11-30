using System;

namespace Day16_methods_vol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Starting the code");
            #region void + NO parameters

            PrintWeather();
            PrintWeather();
            PrintSomeKindOfNamesInOurSpecificOrderWeHaveChosenAtRandom();

            #endregion
            #region void + 1 parameter

            //PrintWeatherNTimes(); //WILL NOT WORK, method !!!NEEDS!!! the int value
            PrintWeatherNTimes(10);

            int weatherMessageCount = 4;
            PrintWeatherNTimes(weatherMessageCount);

            int userMessageCount = int.Parse(Console.ReadLine());
            PrintWeatherNTimes(userMessageCount);

            PrintFavoriteColor("black");

            string myFavColor = "red";
            PrintFavoriteColor(myFavColor);

            string userColor = Console.ReadLine();
            PrintFavoriteColor(userColor);

            #endregion
            #region returns int + 2 parameters

            int sum1 = GetSum(1234, 4321);
            Console.WriteLine($"The first sum is {sum1}");

            int sum2 = GetSumFromIntAndString(1234, "777666");
            Console.WriteLine($"The first sum is {sum2}");

            #endregion
            #region returns string + NO parameters
            string prediction1 = GetPrediction(); Console.WriteLine($"Prediction nr.1: {prediction1}");
            string prediction2 = GetPrediction(); Console.WriteLine($"Prediction nr.2: {prediction2}");
            string prediction3 = GetPrediction(); Console.WriteLine($"Prediction nr.3: {prediction3}");
            string prediction4 = GetPrediction(); Console.WriteLine($"Prediction nr.4: {prediction4}");
            #endregion
            Console.WriteLine("Ending the code");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }

        #region void + NO parameters
        static void PrintWeather()
        {
            Console.WriteLine("Today we got our first real snow this year!");
        }

        static void PrintSomeKindOfNamesInOurSpecificOrderWeHaveChosenAtRandom()
        {
            var names = new string[] { "Toby", "Ann", "Murry", "Tom", "Chris" };
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
        #endregion
        #region void + 1 parameter
        static void PrintWeatherNTimes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Nr.{i+1}: ");
                PrintWeather();
            }
            Console.WriteLine("==============================================");
        }

        static void PrintFavoriteColor(string color)
        {
            Console.WriteLine($"Your favorite color is '{color}'!");
            //Console.ForegroundColor = Enum.Parse(ConsoleColor, "color");
        }
        #endregion
        #region returns int + 2 parameters
        static int GetSum(int firstNumber, int secondNumber)
        {
            //int result = firstNumber + secondNumber;
            //return result;

            //the same as above
            return firstNumber + secondNumber;
        }

        static int GetSumFromIntAndString(int firstNumber, string secondNumberTxt)
        {
            //Some messages
            Console.WriteLine($"The value '{secondNumberTxt}' has {secondNumberTxt.Length} symbols!");
            Console.WriteLine($"Both values are - '{firstNumber}' and '{secondNumberTxt}'.");

            //Calculation secondNumberTxt digit sum
            int digitSum = 0;
            for (int i = 0; i < secondNumberTxt.Length; i++)
            {
                int digit = int.Parse(secondNumberTxt.Substring(i,1));
                digitSum += digit;
            }
            Console.WriteLine($"The digit sum for '{secondNumberTxt}' is {digitSum}");

            //Calculating firstNumber and secondNumber sum
            int secondNumber = int.Parse(secondNumberTxt);
            int sum = firstNumber + secondNumber;
            return sum;
        }
        #endregion
        #region returns string + NO parameters
        static string GetPrediction()
        {
            Random random = new Random();
            int randomValue = random.Next(4);
            string result = string.Empty; //the same as ""
            switch (randomValue)
            {
                case 1:
                    result = "Tomorrow lockdown will be over!";
                    break;
                case 2:
                    result = "Million dollars in your bank account!";
                    break;
                case 3:
                    result = "Snow, snow, SNOW!";
                    break;
                default:
                    result = "Nobody knows what will happen tomorrow!";
                    break;
            }
            return result;
        }
        #endregion
    }
}

//how does data move between Main method and our own custom created methods
//
//difference between returning values and passing values as parameters
//
//methods with parameters. gathering data from user. if user hasn't given any data.
//examples for methods with parameters + Console.ReadLine
//
//default values, when user doesn't input 1 value.
//when user inputs empty string
//
//getting info in 1 method and printing in another
//
//options when generating lists
//
//