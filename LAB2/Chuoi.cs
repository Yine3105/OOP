using System;

public class Chuoi
{
    public string s { get; set; }
    public int x { get; set; }
    public int y { get; set; }
    public ConsoleColor background_color;
    public ConsoleColor font_color;

    // Constructor không tham số
    public Chuoi()
    {
        this.s = "";
        this.x = 0;
        this.y = 0;
        this.background_color = ConsoleColor.Black;
        this.font_color = ConsoleColor.White;
    }

    // Constructor có tham số
    public Chuoi(string s, int x, int y, ConsoleColor bg_color, ConsoleColor fg_color)
    {
        if (string.IsNullOrEmpty(s))
            this.s = "000000";
        else if (string.IsNullOrEmpty(s.Trim()))
            this.s = "11111";
        else
            this.s = s;  
        this.x = x;
        this.y = y;
        background_color = bg_color;
        font_color = fg_color;
    }
    public void Show()
    {
        try
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(s);
            Console.CursorVisible = false;
            ConsoleKeyInfo phim = Console.ReadKey(true);
        }
        catch (Exception)
        {   
        }
        
    }
    public void Move()
    {
        Console.BackgroundColor = background_color;
        Console.ForegroundColor = font_color;
        Console.WindowHeight = 50;
        Console.WindowWidth = 50;
        ConsoleKeyInfo key;
        bool run = true;
        //theo cach do while
        //do
        //{
        //    Show();
        //    key = Console.ReadKey(true);
        //    switch (key.Key)
        //    {
        //        case ConsoleKey.LeftArrow:
        //            x--;
        //            break;
        //        case ConsoleKey.RightArrow:
        //            x++;
        //            break;
        //        case ConsoleKey.UpArrow:
        //            y--;
        //            break;
        //        case ConsoleKey.DownArrow:
        //            y++;
        //            break;
        //    }
        //} while (key.Key != ConsoleKey.Escape);
        while (run)
        {
            Show();
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    x--;
                    break;
                case ConsoleKey.RightArrow:
                    x++;
                    break;
                case ConsoleKey.UpArrow:
                    y--;
                    break;
                case ConsoleKey.DownArrow:
                    y++;
                    break;
                case ConsoleKey.Escape:
                    run = false;
                    break;
            }
        }
    }
}