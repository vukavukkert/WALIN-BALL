Console.CursorVisible = false;
int size = 21;
int x = size/2;
int y = size/2;
Console.WriteLine("press any key...");

while (true)
{
    string[][] grid = new string[size][];
    for (int i = 0; i < grid.Length; i++)
    {
        grid[i] = new string[size];
        for (int j = 0; j < grid[i].Length; j++)
        {
            grid[i][j] = "  ";

            if (i == y && j == x)
            {
                grid[i][j] = "O ";
            }
        }
    }
    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[i].Length; j++)
        {
            Console.Write($"{grid[i][j]}");
        }
        Console.Write("\n");
    }
    Console.WriteLine("coords: x:" + x + " y:" + y);

    var key = Console.ReadKey();
    switch (key.Key)
    {
        case (ConsoleKey.LeftArrow):
            x--;
            break;
        case (ConsoleKey.RightArrow):
            x++;
            break;
        case (ConsoleKey.UpArrow):
            y--;
            break;
        case (ConsoleKey.DownArrow):
            y++;
            break;
    }
    Console.Beep();
    Console.Clear();
}
