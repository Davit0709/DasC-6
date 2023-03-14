using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число:");
        int number = int.Parse(Console.ReadLine());

        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
        {
            Console.WriteLine($"{number} - палиндром");
        }
        else
        {
            Console.WriteLine($"{number} - не палиндром");
        }
    }

    static bool IsPalindrome(int number)
    {
        string str = number.ToString();

        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}

