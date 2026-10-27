namespace task_seach
{

    using System;



    static void Main(string[] args)
    {





internal class Program
    {
        static void CheckVowels(string text)
        {
            if (!text.Contains('a') &&
                !text.Contains('e') &&
                !text.Contains('i') &&
                !text.Contains('o') &&
                !text.Contains('u') &&
                !text.Contains('A') &&
                !text.Contains('E') &&
                !text.Contains('I') &&
                !text.Contains('O') &&
                !text.Contains('U'))
            {
                throw new Exception("The string does not contain vowels.");
            }

            Console.WriteLine("The string contains vowels.");
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a string:");
                string text = Console.ReadLine();

                CheckVowels(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

 
}

/*
 
  static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter integers separated by spaces:");
                string[] input = Console.ReadLine().Split();

                int[] numbers = Array.ConvertAll(input, int.Parse);

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            throw new Exception("Duplicate number found: " + numbers[i]);
                        }
                    }
                }

                Console.WriteLine("No duplicate numbers found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
 
}

 
 
 
 
 */