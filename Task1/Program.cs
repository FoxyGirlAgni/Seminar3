//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
static int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

static bool isPalindromeInt(int num)
{
    int temp = num;
    int revert = 0;

    while (temp > 0)
    {
        revert = (revert * 10) + (temp % 10);
        temp /= 10;
    }
    return revert == num;
}


static bool isPalindromeString(string str)
{
    int size = str.Length;

    for (int i = 0; i < size / 2; ++i)
    {
        if (str[i] != str[size - 1 - i])
        {
            return false;
        }
    }
    return true;
}


int numPalindrome = SetNumber("Palindrome");

bool isPalindrome = isPalindromeInt(numPalindrome);

string str = isPalindrome ? "является палиндромом" : "не является палиндромом";

System.Console.WriteLine($"число {numPalindrome} {str}");



