using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame;

public abstract class DebugConsole
{
    public static void Write(object msg)
    {
        Console.Write(msg);
    }

    public static void WriteLine(object msg)
    {
        Console.WriteLine(msg);
    }

    public static void Write(object msg, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(msg);
        Console.ResetColor();
    }

    public static void WriteLine(object msg, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(msg);
        Console.ResetColor();
    }
}