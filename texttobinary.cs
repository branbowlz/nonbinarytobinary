using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
//Will need a way for the words to be stored.
//Will need a way to read what words are put down
//Will need a way to limit how many options there are, probably an if and while statements
//Incorporate a boolean to restart the reading from the top(optional, can be done later)
namespace TextToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //boolean established here for later use for looping the project
            bool goAgain = true;
            Console.WriteLine("This program will take the words 'one' and 'zero' and convert said numbers");
            Console.WriteLine("into their corresponding numbers. The max limit that the number can be is");
            Console.WriteLine("eight charcters long.");
            while (goAgain == true)
            {
                Console.WriteLine("Please enter in either the word 'one' or 'zero' separated by a space");

                //this string goes to the function
                string nBString = Console.ReadLine();

                //function is called here. nBString is referencing binaryString
                WordToNum(nBString);
                Console.WriteLine();


                //Optional, added in a way for it to loop should the user want to go again
                Console.WriteLine("Would you like to go again? Type 'Y' for yes or 'N' for no");
                string onceMore=Console.ReadLine();
                if(onceMore == "Y" || onceMore == "y") 
                {
                    goAgain = true;
                }else if(onceMore == "N" || onceMore == "n") 
                {
                    goAgain=false;
                    Console.WriteLine("Ending program. Thanks for using!");
                }
                else 
                {
                    Console.WriteLine("Invalid Entry.Program resetting.");
                    goAgain = true;
                }
            }
        }
        static string[] WordToNum(string binaryString)
        {
           string[]words = binaryString.Split(' ');
            
            foreach(var word in words)
            {
                //as the foreach loops through the "words" array, this determines whether it reads 
                //"one" or "zero". Any statements other than that are skipped over

                if (word == "one")
                {
                    Console.Write("1");
                }
                if (word == "zero")
                {
                    Console.Write("0");
                }
                else 
                {
                    Console.Write(" ");
                }
                //Console.WriteLine(word);
            }
            //this returns words, which is a string array of numbers now
            return words;
        }
    }
}