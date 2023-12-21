using System;

class Program
{
    static void Main()
    {
        // Въведете парола от потребителя
       
        string password = Console.ReadLine();

        // Проверете дали въведената парола съвпада с фразата "s3cr3t!P@ssw0rd"
        if (password == "s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
