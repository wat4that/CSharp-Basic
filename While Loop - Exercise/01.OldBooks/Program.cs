string searchedBooks = Console.ReadLine();

int checkedBooksCounter = 0;


while (true)
{
    string currentBook = Console.ReadLine();
    if (currentBook == searchedBooks)
    {
        Console.WriteLine($"You checked {checkedBooksCounter} books and found it.");
        break;
    }
    if (currentBook == "No More Books")
    {
        Console.WriteLine($"The book you search is not here!");
        Console.WriteLine($"You checked {checkedBooksCounter} books.");
        break;
    }
    checkedBooksCounter++;
}