// 1.Write a C# Sharp program that takes email and password as input (type string).
// After 3 wrong attempts, user will be rejected.
void exercise1()
{ 
    string email;
    string password;
    int attempts = 3;

    while(attempts > 0)
    {
        Console.WriteLine("Introduce email: ");
        email = Console.ReadLine();
        Console.WriteLine("Introduce password: ");
        password = Console.ReadLine();

        if (email == "email" && password == "password"){
            Console.WriteLine("email and password CORECT");
            break;
        }
        else{
            Console.WriteLine("Email or password invalid. Try again");
        }

        attempts--;
        if (attempts <= 2){
            Console.WriteLine($"You have {attempts} more attempts");
        }
        
    }
}

// 2.Write a C# Sharp program that takes a character as input and
// check the input (lowercase) is a vowel, a digit, or any other symbol.
void exercise2()
{
    string inputText;
    char character;

    while (true)
    {
        Console.WriteLine("Introduce a single character: ");
        inputText = Console.ReadLine();

        if(inputText.Length == 1)
        {
            character = inputText.ToCharArray()[0];

            if ("aeiou".Contains(Char.ToLower(character)))
            {
                Console.WriteLine($"{character} is a vowel");
            }
            else if (char.IsDigit(character))
            {
                Console.WriteLine($"{character} is a digit");
            }
            else if (char.IsSymbol(character))
            {
                Console.WriteLine($"{character} is a symbol");
            }
            else { 
                Console.WriteLine($"{character} is something else"); 
            }
            break;
        }
    }
}

// 3.Write a C# Sharp program that takes two numbers as input and
// returns true or false when both numbers are even or odd.

bool exercise3()
{
    string string1;
    string string2;
    int number1;
    int number2;

    while (true)
    {
        Console.WriteLine("number1 = ");
        string1 = Console.ReadLine();
        Console.WriteLine("number2 = ");
        string2 = Console.ReadLine();
        try
        {
            number1 = Convert.ToInt32(string1);
            number2 = Convert.ToInt32(string2);

            if (number1 % 2 == 0 && number2 % 2 == 0)
            {
                return true;
            }
            else if (number1 % 2 != 0 && number2 % 2 != 0)
            {
                return true;
            }
            return false;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

bool isPalindrome(string _inputstr)
{
    string _reversestr = string.Empty;

    if (_inputstr != null)
    {
        for (int i = _inputstr.Length - 1; i >= 0; i--)
        {
            _reversestr += _inputstr[i].ToString();
        }
        if (_reversestr == _inputstr)
        {
            return true;
        }
    }
    return false;
}

// 4.Write a C# Sharp program that takes an array of strings as input and
// return the number of existing palindromes.
int exercise4()
{
    string lengthStr;
    int length;
    int numberOfPalindromes = 0;

    while (true)
    {
        Console.WriteLine("Introduce the length of array: ");
        lengthStr = Console.ReadLine();
        try
        {
            length = Convert.ToInt32(lengthStr);
            string[] strings = new string[length];
            Console.WriteLine($"Introduce {length} words: ");

            for (int i = 0; i < length; i++)
            {
                strings[i] = Console.ReadLine();
                if (isPalindrome(strings[i]))
                {
                    numberOfPalindromes++;
                }
            }
            return numberOfPalindromes;
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    
}

//exercise1();
//exercise2();
//Console.WriteLine(exercise3());
Console.WriteLine($"The number of palindromes is {exercise4()}");



