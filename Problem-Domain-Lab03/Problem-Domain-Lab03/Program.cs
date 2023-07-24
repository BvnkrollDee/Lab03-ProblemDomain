using System;
using System.IO;

namespace Problem_Domain_Lab03;

class Program
{
    static void Main(string[] args)
    {
        int product = Challenge1();
        Console.WriteLine("{0}", product);
        Challenge2();
        Challenge3();
        Challenge4();
        Challenge5();
        Challenge6();
    }


    public static int Challenge1()

    {
        Console.WriteLine("Please enter 3 numbers seperated by spaces:");
        string userInput = Console.ReadLine();
        string[] numbers = userInput.Split(" ");
        if (numbers.Length < 3)
        {
            return 0;
        }
        int firstNumber = Convert.ToInt32(numbers[0]);
        int secondNumber = Convert.ToInt32(numbers[1]);
        int thirdNumber = Convert.ToInt32(numbers[2]);
        int product = firstNumber * secondNumber * thirdNumber;
        if (numbers.Length > 3)
        {
            return product;
        }
        else
        {

            return product;
        }
        //Console.WriteLine("{0}, {1}, {2}", numbers);
    }



    public static void Challenge2()
    {
        Console.Write("Please enter a number a number between 2-10: ");
        string userInput = Console.ReadLine();
        int numberOfInstances = Convert.ToInt32(userInput);

        int sum = 0;
        for (int i = 0; i < numberOfInstances; i++)
        {
            Console.WriteLine($"{i + 1} of {numberOfInstances} - Enter a number: ");
            string numberEntered = Console.ReadLine();
            int enteredNumberConverted = Convert.ToInt32(numberEntered);
            sum += enteredNumberConverted;
        }

        int average = sum / numberOfInstances;
        Console.WriteLine($"The average of these numbers is: {average}");
    }



    public static void Challenge3()
    {
        Console.WriteLine("      *");
        Console.WriteLine("     ***");
        Console.WriteLine("    *****");
        Console.WriteLine("   *******");
        Console.WriteLine("  *********");
        Console.WriteLine("   *******");
        Console.WriteLine("    *****");
        Console.WriteLine("     ***");
        Console.WriteLine("      *");
    }


    public static void Challenge4()
    {
        int[] numbers = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
        int mostSeen = numbers[0];
        int highestScore = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            int timesSeen = 1;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (currentNumber == numbers[j])
                {
                    timesSeen += 1;
                }
            }
            if (timesSeen > highestScore)
            {
                mostSeen = currentNumber;
                highestScore = mostSeen;
            }
        }
        Console.WriteLine($"this is the mode of the current array{mostSeen}");
    }


    public static void Challenge5()
    {
        int[] numbers = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
        int highestNumber = 0;

        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > highestNumber)
            {
                highestNumber = numbers[i];
            }
        }
        Console.WriteLine($"This the biggest dude in the array{highestNumber}");
    }



    public static void Challenge6()
    {
        Console.WriteLine("Give me word");
        string word = Console.ReadLine();
        File.WriteAllText("/Users/bvnkrolldee/documents/github/reading-notes/Lab03-ProblemDomain/problem-domain-lab03/problem-domain-lab03/words.txt", word);
    }

    public static void Challenge7()
    {
        string contents = File.ReadAllText("/Users/bvnkrolldee/documents/github/reading-notes/Lab03-ProblemDomain/problem-domain-lab03/problem-domain-lab03/words.txt");
        Console.WriteLine(contents);
    }

    public static void Challenge8()
    {
        string contents = File.ReadAllText("/Users/bvnkrolldee/documents/github/reading-notes/Lab03-ProblemDomain/problem-domain-lab03/problem-domain-lab03/words.txt");
        string[] words = contents.Split(" ");
        words[words.Length - 1] = "";
        string updatedContents = "";
        foreach( string word in words)
        {
            updatedContents += word;
        }
        File.WriteAllText("C:\\Users\\raygr\\Documents\\Dev\\SandBox\\Lab3\\words.txt", updatedContents);
    }





    public static void Challenge9()
    {
        Console.WriteLine("Please enter a sentence");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(" ");
        for(int i = 0; i < words.Length; i++)
        {
            int numberOfLetters = words[i].Length;
            words[i] = $"{words[i]}: {numberOfLetters}";
            Console.Write($"{words[i]}");
        }
    }
}

