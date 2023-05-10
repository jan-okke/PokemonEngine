using System;
using System.Collections.Generic;

namespace PokemonGame.Entities;

public class TextQueue
{
    private List<string> Texts { get; }

    public TextQueue()
    {
        Texts = new List<string>();
    }

    public void Add(string text)
    {
        Texts.Add(text);
    }

    public bool HasNext()
    {
        return Texts.Count > 0;
    }

    public string Next()
    {
        if (!HasNext())
        {
            DebugConsole.WriteLine("Warning - TextQueue is empty!", ConsoleColor.Yellow);
            return default;
        }

        var text = Texts[0];
        Texts.Remove(text);
        return text;
    }
}