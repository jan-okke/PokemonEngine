using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PokemonGame.Entities;
using PokemonGame.Enums;
using PokemonGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class PokemonGame
    {
        private const int PlayerMoves = Settings.PlayerMoveSpeed;
        private Map CurrentMap;
        private Player Player;
        private int Width;
        private int Height;

        public TextQueue TextQueue { get; }
        public MovementQueue MovementQueue { get; }
        public PokemonGame(int preferredBackBufferWidth, int preferredBackBufferHeight) 
        {
            Width = preferredBackBufferWidth;
            Height = preferredBackBufferHeight;
            TextQueue = new TextQueue();
            MovementQueue = new MovementQueue();
        }
        public void SetMap(Map map)
        {
            CurrentMap = map;
        }
        private void HandleEvents()
        {
            foreach (Event e in CurrentMap.Events)
            {
                if (e.Handled) continue;
                if (e.Trigger == EventTrigger.Touch && e.Tile == Player.Position.X + Player.Position.Y * CurrentMap.Width)
                {
                    e.Handle(this);
                } 
            }
        }
        private void HandleEventsActiveButton()
        {
            int? tile =
                Player.State == PlayerState.Left ? Player.Position.X - 1 + Player.Position.Y * CurrentMap.Width :
                Player.State == PlayerState.Right ? Player.Position.X + 1 + Player.Position.Y * CurrentMap.Width :
                Player.State == PlayerState.Down ? Player.Position.X + (Player.Position.Y + 1) * CurrentMap.Width :
                Player.State == PlayerState.Up ? Player.Position.X + (Player.Position.Y - 1) * CurrentMap.Width : null;
            if (tile is null) { DebugConsole.WriteLine("Invalid Player State!", ConsoleColor.Red); return; }
            foreach (Event e in CurrentMap.Events)
            {
                if (e.Handled) continue;
                if (e.Trigger == EventTrigger.Button && e.Tile == tile)
                {
                    e.Handle(this);
                }
            }
        }
        public void Update(KeyboardState keyboardState)
        {
            // if the player is currently in an animation, continue animation
            if (Player.InAnimation)
            {
                switch (Player.State)
                {
                    case PlayerState.Left: Player.DisplayX -= PlayerMoves; break;
                    case PlayerState.Right: Player.DisplayX += PlayerMoves; break;
                    case PlayerState.Down: Player.DisplayY += PlayerMoves; break;
                    case PlayerState.Up: Player.DisplayY -= PlayerMoves; break;
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
                        Player.RunningState = 0; break;
                    case Keys.Left:
                        if (Player.State == PlayerState.Left && CurrentMap.IsTilePassable(Player.Position.X - 1, Player.Position.Y)) { Player.DisplayX -= PlayerMoves; Player.RunningState++; break; }
                        Player.State = PlayerState.Left; Player.RunningState = 0; break;
                    case Keys.Right:
                        if (Player.State == PlayerState.Right && CurrentMap.IsTilePassable(Player.Position.X + 1, Player.Position.Y)) { Player.DisplayX += PlayerMoves; Player.RunningState++; break; }
                        Player.State = PlayerState.Right; Player.RunningState = 0; break;
                    case Keys.Down:
                        if (Player.State == PlayerState.Down && CurrentMap.IsTilePassable(Player.Position.X, Player.Position.Y + 1)) { Player.DisplayY += PlayerMoves; Player.RunningState++; break; }
                        Player.State = PlayerState.Down; Player.RunningState = 0; break;
                    case Keys.Up:
                        if (Player.State == PlayerState.Up && CurrentMap.IsTilePassable(Player.Position.X, Player.Position.Y - 1)) { Player.DisplayY -= PlayerMoves; Player.RunningState++; break; }
                        Player.State = PlayerState.Up; Player.RunningState = 0; break;
                    // if some other key is pressed, ignore it.
                    default:
                        Player.RunningState = 0; break;
                }
            }
            // if no key pressed, return to default state
            else
            {
                Player.RunningState = 0;
            }
        }
        private bool HandleMovementQueue()
        {
            // returns true if forced move
            if (MovementQueue.HasNext())
            {
                ICommand cmd = MovementQueue.Next();
                switch (cmd.GetEventCommandType()) 
                {
                    case EventCommandType.MoveCommmand:
                        var _cmd = (MoveCommand)cmd;
                        MovePlayer(_cmd.Direction);
                        return true;
                    case EventCommandType.RotateCommand:
                        _cmd = (MoveCommand)cmd;
                        RotatePlayer(_cmd.Direction);
                        return true;
                    case EventCommandType.WarpCommand:
                        var __cmd = (WarpCommand)cmd;
                        WarpPlayer(__cmd.X, __cmd.Y);
                        return true;
                    default:
                        DebugConsole.WriteLine("Warning - Unknown Movement Command EventCommandType.", ConsoleColor.Yellow);
                        return false;
                }
            }
            return false;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            DrawTextBox(spriteBatch);
            CurrentMap.Draw(Width, Height, Player, spriteBatch);
            spriteBatch.End();
        }
        private void MovePlayer(string direction)
        {
            // This method should only be called by Events since it bypasses Collision Detection.
            switch (direction)
            {
                case "left" or "Left":
                    Player.State = PlayerState.Left;
                    Player.DisplayX -= PlayerMoves; break;
                case "right" or "Right":
                    Player.State = PlayerState.Right;
                    Player.DisplayX += PlayerMoves; break;
                case "up" or "Up":
                    Player.State = PlayerState.Up;
                    Player.DisplayY -= PlayerMoves; break;
                case "down" or "Down":
                    Player.State = PlayerState.Down;
                    Player.DisplayY += PlayerMoves; break;
            }
        }
        private void RotatePlayer(string direction)
        {
            // This method should only be called by Events since it bypasses Collision Detection.
            switch (direction)
            {
                case "left" or "Left":
                    Player.State = PlayerState.Left;
                    break;
                case "right" or "Right":
                    Player.State = PlayerState.Right;
                    break;
                case "up" or "Up":
                    Player.State = PlayerState.Up;
                    break;
                case "down" or "Down":
                    Player.State = PlayerState.Down;
                    break;
            }
        }

        private void WarpPlayer(int x, int y)
        {
            Player.Position = new Point(x, y);
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
            SetMap(MapCollection.Maps[Settings.StartMapID]);
        }

        public void SetPlayer()
        {
            Player = new Player(ContentCollection.Textures["Player"], 64);
        }
        public void SetPlayerCoord(int x, int y)
        {
            Player.Position = new Point(x, y);
        }
    }
}
