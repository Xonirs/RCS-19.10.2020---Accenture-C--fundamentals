using System;

namespace Day12_stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My dog is very cute, but in the morning he is so LOUD, that i wake up.";
            Console.WriteLine("Sentence:");
            Console.WriteLine(sentence);

            //string.IsNullOrEmpty({ string type variable});
            //IsNullOrEmpty - checks if the string type variable is empty or a non-existing value (null)
            bool emptySentence = string.IsNullOrEmpty(sentence); //false
            var test1 = "";
            if (string.IsNullOrEmpty(test1)) 
            {
                Console.WriteLine("Test1 variable has no value");
            }

            //{ string type variable}.Substring({starting position}, { length});
            //{ string type variable}.Substring({starting position});
            //Substring - gets a part of a string
            //1st option - set a starting position and show how many characters to take
            //2nd option - set just a starting position and Substring will take everything till the end
            string tenCharactersFrom5thIndex = sentence.Substring(5, 10); Console.WriteLine(tenCharactersFrom5thIndex);
            string from8thIndexTillEnd = sentence.Substring(8); Console.WriteLine(from8thIndexTillEnd);

            //{ string type variable}.Length;
            //Length - get the character count for a string
            int length = sentence.Length; Console.WriteLine($"Sentence length is {length}");

            //{ string type variable}.StartsWith({ searchable string});
            //StartsWith - checks if a string variable starts EXACTLY with the searchable string;
            Console.WriteLine("StartsWith:");
            bool startsWith1 = sentence.StartsWith("My dog is"); Console.WriteLine(startsWith1); // true
            bool startsWith2 = sentence.StartsWith("my dog is"); Console.WriteLine(startsWith2); // false
            bool startsWith3 = sentence.StartsWith("dog"); Console.WriteLine(startsWith3); // false
            bool startsWith4 = sentence.StartsWith("My"); Console.WriteLine(startsWith4); // true
            bool startsWith5 = sentence.StartsWith("my dog is", StringComparison.OrdinalIgnoreCase); Console.WriteLine(startsWith5); // true

            //{ string type variable}.EndsWith({ searchable string});
            //EndsWith - checks if a string variable ends EXACTLY with the searchable string;
            Console.WriteLine("EndsWith:");
            bool endsWith1 = sentence.EndsWith("i wake up"); Console.WriteLine(endsWith1); // false
            bool endsWith2 = sentence.EndsWith("up."); Console.WriteLine(endsWith2); // true
            bool endsWith3 = sentence.EndsWith("UP.", StringComparison.OrdinalIgnoreCase); Console.WriteLine(endsWith3); // true

            //{ string type variable}.Contains({ searchable string});
            //Contains - checks if a string variable CONTAINS the searchable string. that means the searchable string can be ANYWHERE
            Console.WriteLine("Contains:");
            bool containsWith1 = sentence.Contains("i wake up"); Console.WriteLine(containsWith1); // true
            bool containsWith2 = sentence.Contains("L"); Console.WriteLine(containsWith2); // true            
            bool containsWith3 = sentence.Contains("My dog is"); Console.WriteLine(containsWith3); // true
            bool containsWith4 = sentence.Contains("up."); Console.WriteLine(containsWith4); // true
            bool containsWith5 = sentence.Contains("dog wake"); Console.WriteLine(containsWith5); // false
            bool containsWith6 = sentence.Contains("."); Console.WriteLine(containsWith6); // true

            //{ string type variable}.ToUpper();
            //ToUpper - turns every string character to upper case
            string upperSentence = sentence.ToUpper(); Console.WriteLine(upperSentence);

            //{ string type variable}.ToLower();
            //ToLower - turns every string character to lower case
            string lowerSentence = sentence.ToLower(); Console.WriteLine(lowerSentence);

            //{ string type variable}.IndexOf({ searchable string});
            //IndexOf - gets the index of a searchable string STARTING LOCATION inside the original string variable value
            Console.WriteLine("IndexOf");
            int index1 = sentence.IndexOf("dog"); Console.WriteLine(index1); //3
            int index2 = sentence.IndexOf("morning"); Console.WriteLine(index2); //32
            //if the string can't be found, then the return value from IndexOf method is -1
            int index3 = sentence.IndexOf("morning1"); Console.WriteLine(index3); //-1
        }
    }
}
