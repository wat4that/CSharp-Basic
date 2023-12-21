int cakeWidth = int.Parse(Console.ReadLine());
int cakeLength = int.Parse(Console.ReadLine());

int cakeSize = cakeWidth * cakeLength;

string input = Console.ReadLine();
int piecesTaken = 0;

while (input != "STOP")
{
    int pieces = int.Parse(input);
    piecesTaken += pieces;

    if (piecesTaken > cakeSize)
    {
        int piecesNeeded = piecesTaken - cakeSize;
        Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
        return;
    }

    input = Console.ReadLine();
}

int piecesLeft = cakeSize - piecesTaken;
Console.WriteLine($"{piecesLeft} pieces are left.");