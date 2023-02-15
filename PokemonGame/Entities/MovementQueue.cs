using System;
using System.Collections.Generic;

namespace PokemonGame.Entities
{
    public class MovementQueue
    {
        private List<MoveCommand> Commands;

        public MovementQueue()
        {
            Commands = new();
        }
        public void Add(MoveCommand cmd)
        {
            Commands.Add(cmd);
        }
        public bool HasNext()
        {
            return Commands.Count > 0;
        }
        public MoveCommand Next()
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