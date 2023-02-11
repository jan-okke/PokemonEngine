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
        private const int PlayerMoves = 4;

        private Map CurrentMap;
        private Player Player;
        private int Width;
        private int Height;

        public TextBox TextBox;
        public PokemonGame(int preferredBackBufferWidth, int preferredBackBufferHeight) 
        {
            Width = preferredBackBufferWidth;
            Height = preferredBackBufferHeight;
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
                    case PlayerState.Left: Player.X -= PlayerMoves; break;
                    case PlayerState.Right: Player.X += PlayerMoves; break;
                    case PlayerState.Down: Player.Y += PlayerMoves; break;
                    case PlayerState.Up: Player.Y -= PlayerMoves; break;
                }
                return;
            }
            //DebugConsole.WriteLine(Player.Position);

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
                        if (Player.State == PlayerState.Left && CurrentMap.IsTilePassable(Player.Position.X - 1, Player.Position.Y)) { Player.X -= PlayerMoves; Player.RunningState++; break; }
                        Player.State = PlayerState.Left; Player.RunningState = 0; break;
                    case Keys.Right:
                        if (Player.State == PlayerState.Right && CurrentMap.IsTilePassable(Player.Position.X + 1, Player.Position.Y)) { Player.X += PlayerMoves; Player.RunningState++; break; }
                        Player.State = PlayerState.Right; Player.RunningState = 0; break;
                    case Keys.Down:
                        if (Player.State == PlayerState.Down && CurrentMap.IsTilePassable(Player.Position.X, Player.Position.Y + 1)) { Player.Y += PlayerMoves; Player.RunningState++; break; }
                        Player.State = PlayerState.Down; Player.RunningState = 0; break;
                    case Keys.Up:
                        if (Player.State == PlayerState.Up && CurrentMap.IsTilePassable(Player.Position.X, Player.Position.Y - 1)) { Player.Y -= PlayerMoves; Player.RunningState++; break; }
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
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            DrawTextBox(spriteBatch);
            CurrentMap.Draw(Width, Height, Player, spriteBatch);
            spriteBatch.End();
        }
        private void DrawTextBox(SpriteBatch spriteBatch)
        {
            if (TextBox != null) 
            {
                DebugConsole.WriteLine(TextBox.Text);
                //spriteBatch.DrawString() => TODO
                TextBox = null;
            }
        }

        public void SetDefaultMap()
        {
            SetMap(Map.LoadFromFile("GameFiles\\Data\\Maps\\Map" + Helpers.StringHelper.Get4DigitString(Settings.StartMapID) + ".txt"));
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
