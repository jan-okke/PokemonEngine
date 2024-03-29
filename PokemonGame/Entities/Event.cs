﻿using PokemonGame.Commands;
using PokemonGame.Enums;
using System;
using System.Collections.Generic;

namespace PokemonGame.Entities;

public class Event
{
    public int Tile { get; private set; }
    private List<EventCommand> Commands { get; set; }
    public EventTrigger Trigger { get; private set; }
    public bool Handled { get; private set; }
    private bool _autoHandle;
    private Event() 
    {
        Handled = false;
        _autoHandle = true;
    }
    public Event(int tile, List<EventCommand> commands, EventTrigger trigger) 
    {
        Tile = tile;
        Commands = commands;
        Trigger = trigger;
        Handled = false;
        _autoHandle = true;
    }
    private static EventCommandType GetEventCommandType(int id)
    {
        return id switch
        {
            0 => EventCommandType.TextCommand,
            1 => EventCommandType.MoveCommmand,
            2 => EventCommandType.RotateCommand,
            3 => EventCommandType.WarpCommand,
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
        var tileData = eventData.Substring(0, eventData.IndexOf(','));
        eventData = eventData.Substring(eventData.IndexOf(',') + 1);
        var triggerData = eventData.Substring(0, eventData.IndexOf(','));
        eventData = eventData.Substring(eventData.IndexOf(',') + 1);
        e.Tile = int.Parse(tileData);
        e.Trigger = GetEventTrigger(int.Parse(triggerData));
        e.Commands = new();
        eventData = eventData[1..];
        var newEventData = eventData;
        foreach (string s in eventData.Substring(0, eventData.IndexOf(']')).Split('|'))
        {
            var sSplit = s.Split(',', 2);
            var commandId = sSplit[0];
            var args = sSplit[1].Split(','); // TODO this wont work lol
            e.Commands.Add(new EventCommand(GetEventCommandType(int.Parse(commandId)), args));
            newEventData = newEventData.Substring(s.Length + 1);
        }
        var split = newEventData.Split(',');
        e._autoHandle = split.Length <= 1 || split[1] != "false";
        e.Handled = false;
        return e;
    }
    public bool Handle(PokemonGame game)
    {
        foreach (var cmd in Commands) 
        {
            switch (cmd.CommandType)
            {
                case EventCommandType.TextCommand:
                    game.TextQueue.Add(cmd.Args[0]);
                    break;
                case EventCommandType.MoveCommmand:
                    game.MovementQueue.Add(new MoveCommand(cmd.Args[0]));
                    break;
                case EventCommandType.RotateCommand:
                    game.MovementQueue.Add(new RotateCommand(cmd.Args[0]));
                    break;
                case EventCommandType.WarpCommand:
                    game.MovementQueue.Add(new WarpCommand(int.Parse(cmd.Args[0]), int.Parse(cmd.Args[1]), int.Parse(cmd.Args[2])));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
            
        if (_autoHandle)
        {
            Handled = true;
        }

        return true;
    }
}