using System;
using System.Collections.Generic;
using PokemonGame.Commands;

namespace PokemonGame.Entities;

public class MovementQueue
{
    private readonly List<ICommand> _commands;

    public MovementQueue()
    {
        _commands = new List<ICommand>();
    }

    public void Add(ICommand cmd)
    {
        _commands.Add(cmd);
    }

    private int Count => _commands.Count;
    public bool HasNext() => Count > 0;

    public ICommand Next()
    {
        if (!HasNext())
        {
            DebugConsole.WriteLine("Warning - MovementQueue is empty!", ConsoleColor.Yellow);
            return default;
        }

        var cmd = _commands[0];
        _commands.Remove(cmd);
        return cmd;
    }
}