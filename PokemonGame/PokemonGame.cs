using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PokemonGame.Commands;
using PokemonGame.Entities;
using PokemonGame.Enums;
using PokemonGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame;

public class PokemonGame
{
    private const int PlayerMoves = Settings.PlayerMoveSpeed;
    private Map _currentMap;
    private Player _player;
    private readonly int _width;
    private readonly int _height;

    public TextQueue TextQueue { get; }
    public MovementQueue MovementQueue { get; }

    public PokemonGame(int preferredBackBufferWidth, int preferredBackBufferHeight)
    {
        _width = preferredBackBufferWidth;
        _height = preferredBackBufferHeight;
        TextQueue = new TextQueue();
        MovementQueue = new MovementQueue();
    }

    public void SetMap(Map map)
    {
        _currentMap = map;
    }

    private void HandleEvents()
    {
        foreach (Event e in _currentMap.Events)
        {
            if (e.Handled) continue;
            if (e.Trigger == EventTrigger.Touch &&
                e.Tile == _player.Position.X + _player.Position.Y * _currentMap.Width)
            {
                e.Handle(this);
            }
        }
    }

    private void HandleEventsActiveButton()
    {
        int? tile =
            _player.State switch
            {
                PlayerState.Left => _player.Position.X - 1 + _player.Position.Y * _currentMap.Width,
                PlayerState.Right => _player.Position.X + 1 + _player.Position.Y * _currentMap.Width,
                PlayerState.Down => _player.Position.X + (_player.Position.Y + 1) * _currentMap.Width,
                PlayerState.Up => _player.Position.X + (_player.Position.Y - 1) * _currentMap.Width,
                _ => null
            };
        if (tile is null)
        {
            DebugConsole.WriteLine("Invalid Player State!", ConsoleColor.Red);
            return;
        }

        foreach (var e in _currentMap.Events.Where(e => !e.Handled).Where(e => e.Trigger == EventTrigger.Button && e.Tile == tile))
        {
            e.Handle(this);
        }
    }

    public void Update(KeyboardState keyboardState)
    {
        // if the player is currently in an animation, continue animation
        if (_player.InAnimation)
        {
            switch (_player.State)
            {
                case PlayerState.Left:
                    _player.DisplayX -= PlayerMoves;
                    break;
                case PlayerState.Right:
                    _player.DisplayX += PlayerMoves;
                    break;
                case PlayerState.Down:
                    _player.DisplayY += PlayerMoves;
                    break;
                case PlayerState.Up:
                    _player.DisplayY -= PlayerMoves;
                    break;
            }

            return;
        }

        // if there are still Movements left in the Queue, handle those first
        if (HandleMovementQueue()) return;
        // Handle Events
        HandleEvents();
        // otherwise get the key press
        var keys = keyboardState.GetPressedKeys();
        if (keys.Length > 0)
        {
            switch (keys[0])
            {
                case Keys.A:
                    HandleEventsActiveButton();
                    _player.RunningState = 0;
                    break;
                case Keys.Left:
                    if (_player.State == PlayerState.Left &&
                        _currentMap.IsTilePassable(_player.Position.X - 1, _player.Position.Y))
                    {
                        _player.DisplayX -= PlayerMoves;
                        _player.RunningState++;
                        break;
                    }

                    _player.State = PlayerState.Left;
                    _player.RunningState = 0;
                    break;
                case Keys.Right:
                    if (_player.State == PlayerState.Right &&
                        _currentMap.IsTilePassable(_player.Position.X + 1, _player.Position.Y))
                    {
                        _player.DisplayX += PlayerMoves;
                        _player.RunningState++;
                        break;
                    }

                    _player.State = PlayerState.Right;
                    _player.RunningState = 0;
                    break;
                case Keys.Down:
                    if (_player.State == PlayerState.Down &&
                        _currentMap.IsTilePassable(_player.Position.X, _player.Position.Y + 1))
                    {
                        _player.DisplayY += PlayerMoves;
                        _player.RunningState++;
                        break;
                    }

                    _player.State = PlayerState.Down;
                    _player.RunningState = 0;
                    break;
                case Keys.Up:
                    if (_player.State == PlayerState.Up &&
                        _currentMap.IsTilePassable(_player.Position.X, _player.Position.Y - 1))
                    {
                        _player.DisplayY -= PlayerMoves;
                        _player.RunningState++;
                        break;
                    }

                    _player.State = PlayerState.Up;
                    _player.RunningState = 0;
                    break;
                // if some other key is pressed, ignore it.
                default:
                    _player.RunningState = 0;
                    break;
            }
        }
        // if no key pressed, return to default state
        else
        {
            _player.RunningState = 0;
        }
    }

    private bool HandleMovementQueue()
    {
        // returns true if forced move
        if (!MovementQueue.HasNext()) return false;
        var cmd = MovementQueue.Next();
        cmd.ExecuteCommand(this);
        return true;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        DrawTextBox(spriteBatch);
        _currentMap.Draw(_width, _height, _player, spriteBatch);
        spriteBatch.End();
    }

    public void MovePlayer(string direction)
    {
        // This method should only be called by Events since it bypasses Collision Detection.
        switch (direction)
        {
            case "left" or "Left":
                _player.State = PlayerState.Left;
                _player.DisplayX -= PlayerMoves;
                break;
            case "right" or "Right":
                _player.State = PlayerState.Right;
                _player.DisplayX += PlayerMoves;
                break;
            case "up" or "Up":
                _player.State = PlayerState.Up;
                _player.DisplayY -= PlayerMoves;
                break;
            case "down" or "Down":
                _player.State = PlayerState.Down;
                _player.DisplayY += PlayerMoves;
                break;
        }
    }

    public void RotatePlayer(string direction)
    {
        // This method should only be called by Events since it bypasses Collision Detection.
        _player.State = direction switch
        {
            "left" or "Left" => PlayerState.Left,
            "right" or "Right" => PlayerState.Right,
            "up" or "Up" => PlayerState.Up,
            "down" or "Down" => PlayerState.Down,
            _ => _player.State
        };
    }

    public void WarpPlayer(int mapId, int x, int y)
    {
        if (mapId == _currentMap.MapId)
        {
            _player.Position = new Point(x, y);
        }
        else
        {
            SetMap(MapCollection.Maps[mapId]);
            _player.Position = new Point(x, y);
        }
    }

    private void DrawTextBox(SpriteBatch spriteBatch)
    {
        if (TextQueue.HasNext())
        {
            DebugConsole.WriteLine(TextQueue.Next());
        }
    }

    public void SetDefaultMap()
    {
        SetMap(MapCollection.Maps[Settings.StartMapId]);
    }

    public void SetPlayer()
    {
        _player = new Player(ContentCollection.Textures["Player"], 64);
    }

    public void SetPlayerCoord(int x, int y)
    {
        _player.Position = new Point(x, y);
    }
}