    string favouriteBook = Console.ReadLine();
    string searchBook = Console.ReadLine();
    int count = 0;
    bool found = false;

    for (string book = Console.ReadLine(); book != "No More Books"; book = Console.ReadLine())
    {
        count++;

        if (book == searchBook)
        {
            Console.WriteLine($"You checked {count} books and found it.");
            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {count} books.");
    }
