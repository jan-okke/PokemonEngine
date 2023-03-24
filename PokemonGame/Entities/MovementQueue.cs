using System;
using System.Collections.Generic;

namespace PokemonGame.Entities
{
    public class MovementQueue
    {
        private List<ICommand> Commands;

        public MovementQueue()
        {
            Commands = new();
        }
        public void Add(MoveCommand cmd)
        {
            Commands.Add(cmd);
        }
        public void Add(WarpCommand cmd) {
            Commands.Add(cmd);
        }
        public int Count() => Commands.Count;
        public bool HasNext()
        {
            return Commands.Count > 0;
        }
        public ICommand Next()
        {
            if (!HasNext()) 
            {
                DebugConsole.WriteLine("Warning - MovementQueue is empty!", ConsoleColor.Yellow);
                return default;
            }
            var cmd = Commands[0];
            Commands.Remove(cmd);
            return cmd;
        }
    }
}