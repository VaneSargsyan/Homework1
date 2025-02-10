using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Task1
/*namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            int num1 = 0;
            int count = 0;
            while (num1 != num)
            {
                Console.WriteLine("Guess the number");
                string input = Console.ReadLine();


                if (int.TryParse(input, out num1))
                {
                    count++;
                    if (num1 > num)
                    {
                        Console.WriteLine("Your guessed number is too high\n");
                    }
                    if (num1 < num)
                    {
                        Console.WriteLine("Your guessed number is too low\n");

                    }
                    if (num1 == num)
                    {
                        Console.WriteLine("Happpyyyyy!!!!!You guess the number\n");
                    }
                }
                else
                {
                    Console.WriteLine("Your number is not correct");
                }


            }
        }
    }
}*/

/*Task2*/
/*using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1,101);

            }
            Console.WriteLine("Numbers are");
            foreach (var num in numbers)
            {
                Console.WriteLine(+num);
            }
            Console.WriteLine();
            int largenumber = numbers[0];
            foreach (var num in numbers)
            {
                if (num > largenumber)
                {
                    largenumber = num;
                }
            }
            Console.WriteLine("Large number is - " + largenumber);
        }
    }
}
*/

/*Task3*/
/*using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[20];
            int counteven= 0;
            int countodd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 51);
            }
            Console.WriteLine("Numbers are");
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    counteven++;
                }
                else
                {
                    countodd++;
                }
            }
            foreach(var num in numbers)
            {
                Console.WriteLine(+num);
            }
            Console.WriteLine();
            Console.WriteLine("Odd numbers are" + countodd);
            Console.WriteLine("Even numbers are" + counteven);
            }
        }
    }
*/

/*Task4*/
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1,11);
            }
            Console.WriteLine("Numbers are");
            foreach (int num in numbers)
            {
                sum += num;

            }
            foreach (int num in numbers)
            {
                Console.WriteLine(+num);
            }
            Console.WriteLine();
            Console.WriteLine("The sum of numbers is-" + sum);
        }
    }
}*/

/*Task5*/
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            char[] pas = new char[8];

            for (int i = 0; i < pas.Length; i++)
            {
                int charType = rnd.Next(0, 3);
                if (charType == 0) 
                {
                    pas[i] = (char)rnd.Next('0', '9' + 1);
                }
                else if (charType == 1)
                {
                    pas[i] = (char)rnd.Next('a', 'z' + 1);
                }
                else
                {
                    pas[i] = (char)rnd.Next('A', 'Z' + 1);
                }
            }

            Console.WriteLine("The password is-" +new string(pas));
        }
    }
}*/


/*Task 6*/
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[15];

            Console.WriteLine("Numbers are\n");
            for(int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = rnd.Next();
            }
            foreach (int num in numbers)
            {
                Console.WriteLine(+num);
            }
            Console.WriteLine();
            int largeNum = numbers[0];
            int smallNum = numbers[0];
            foreach (int num in numbers)
            {
                if (num > largeNum)
                {
                    largeNum = num;
                }
                if (num < smallNum)
                {
                    smallNum = num;
                }
            }
            Console.WriteLine("The largest number is-" + largeNum);
            Console.WriteLine("The smallest number is -" + smallNum);
        }
    }
}*/

/*Task7*/
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next();

            }
            Console.WriteLine("The array is\n");
            foreach (int num in numbers)
            {
                Console.WriteLine(+num);
            }
            Console.WriteLine();
            int temp;
            int start = 0;
            int end = numbers.Length - 1;
            while(start < end)
            {
                temp = numbers[start];
                numbers[start] = numbers[end];
                numbers[end] = temp;
                start++;
                end--;

            }
            Console.WriteLine("The array with reversed mode is\n");
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}*/

/*Task8*/
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            string[] words = { "apple", "banana", "cherry", "grape" };
            Random rnd = new Random();
            int RandomSelected = rnd.Next(0, words.Length);
            string randomcharacter = words[RandomSelected];
            
            string wordGuess = "";
            while (wordGuess != randomcharacter)
            {
                Console.WriteLine("Guess the word");
                wordGuess = Console.ReadLine().ToLower();
               if (wordGuess == randomcharacter)
                {
                    Console.WriteLine("Happy! You guess the word");
                }
                else
                {
                    Console.WriteLine("It's false");
                }
                
            }
            Console.WriteLine();
        }
    }
}*/


/*Task9*/
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int result = rnd.Next(1, 7);
                Console.WriteLine(+(i + 1) + "Roll is" + result);

            }
        }
    }
}


//Task10
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            int size = 10;
            Console.WriteLine("The multiplication table of numbers from 1 to 10 is:\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine(i * j );
                }
            }
        
        }
    }
}*/

//Task11
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[20];
            int sumPositive = 0;
            int sumNegative = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-50, 50);
            }
            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    sumPositive += num;
                }
                else
                {
                    sumNegative += num;
                }
            }
            Console.WriteLine("The sum of positive numbers is:\n" + sumPositive);
            Console.WriteLine("The sum of negative numbers is:\n" + sumNegative);
        }
      */


//Task12
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 10);
            }
            Console.WriteLine("Our numbers are:\n");
            foreach (int num in numbers)
            {
                Console.WriteLine(+num);
            }
            Console.WriteLine();
            bool findDuplicates = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Console.WriteLine("Duplicate number is:\n" + numbers[i]);
                        findDuplicates = true;
                        break;
                    }
                }
            }*/


//Task13
/*using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            string[] subjects = { "The dog", "The cat", "The bird" };
            string[] verbs = { "Eats", "Jumps", "Fly" };
            string[] objects = { "Meat", "over the fence", "in the sky" };

            Random rnd = new Random();

            string subject = subjects[rnd.Next(subjects.Length)];
            string verb = verbs[rnd.Next(verbs.Length)];        
            string obj= objects[rnd.Next(objects.Length)];

            string sentence = subject + verb + obj;
            Console.WriteLine("Our sentence is:" + sentence);

        }
    }
}*/


//Task14
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Homework1
{
    internal class Program
    {
        static void Main()
        {
            string[] rps = { "Rock", "Paper", "Scissors" };
            Random rnd = new Random();
            Console.WriteLine("This is the game Rock Paper Scissors");
            Console.WriteLine("Enter your choice");
            string choice = Console.ReadLine();

            string choiceComp = rps[rnd.Next(rps.Length)];
            Console.WriteLine("Duq yntreciq " + choice);
            Console.WriteLine("Hamakargichy yntrec " + choiceComp);
            string result = DetermineWinner(choice, choiceComp);
            Console.WriteLine(result);
        }
        static string DetermineWinner(string choice, string choiceComp)
        {
            if (choice == choiceComp)
            {
                return "VochVoqi!";
            }
            else if ((choice == "Rock" && choiceComp == "Scissors") ||
                     (choice == "Paper" && choiceComp == "Rock") ||
                     (choice == "Scissors" && choiceComp == "Paper"))
            {
                return "Duq haxteciq!";
            }
            else
            {
                return "Hamakargichy haxtec!";
            }
        }
    }

}

