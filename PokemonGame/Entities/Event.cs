using PokemonGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class Event
    {
        public int Tile { get; set; }
        public EventCommand Command { get; set; }
        public EventTrigger Trigger { get; set; }
        public string[] Args { get; set; }
        public bool Handled { get; private set; }
        private bool AutoHandle;
        private Event() 
        {
            Handled = false;
            AutoHandle = true;
        }
        public Event(int tile, EventCommand command, EventTrigger trigger, string[] args) 
        {
            Tile = tile;
            Command = command;
            Trigger = trigger;
            Args = args;
            Handled = false;
            AutoHandle = true;
        }
        private static EventCommand GetEventCommand(int id)
        {
            return id switch
            {
                0 => EventCommand.TextCommand,
                _ => throw new ArgumentException(null, nameof(id)),
            };
        }
        private static EventTrigger GetEventTrigger(int id)
        {
            return id switch
            {
                0 => EventTrigger.Button,
                1 => EventTrigger.Touch,
                _ => throw new ArgumentException(null, nameof(id)),
            };
        }

        public static Event Parse(string eventData)
        {
            // Remove first and last char { and }
            eventData = eventData.Remove(eventData.Length - 1, 1)[1..];
            Event e = new();
            var split = eventData.Split(',');
            e.Tile = int.Parse(split[0]);
            e.Command = GetEventCommand(int.Parse(split[1]));
            e.Trigger = GetEventTrigger(int.Parse(split[2]));
            e.Args = split[3].Split(",");
            e.AutoHandle = split.Length > 4 ? split[4] == "false" ? false : true : true;
            e.Handled = false;
            return e;
        }
        public bool Handle(PokemonGame game)
        {
            switch (Command)
            {
                case EventCommand.TextCommand:
                    game.TextBox = new TextBox() { Text = Args[0] }; break;
            }
            if (AutoHandle) Handled = true;
            return true;
        }
    }
}
