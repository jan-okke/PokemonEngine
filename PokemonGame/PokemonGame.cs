using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PokemonGame.Entities;
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
        public PokemonGame(int preferredBackBufferWidth, int preferredBackBufferHeight) 
        {
            Width = preferredBackBufferWidth;
            Height = preferredBackBufferHeight;
        }
        public void SetMap(Map map)
        {
            CurrentMap = map;
        }
        public void Update(KeyboardState keyboardState)
        {
            // if the player is currently in an animation, continue animation
            if (Player.InAnimation)
            {
                switch (Player.State)
                {
                    case Enums.PlayerState.Left: Player.X -= PlayerMoves; break;
                    case Enums.PlayerState.Right: Player.X += PlayerMoves; break;
                    case Enums.PlayerState.Down: Player.Y += PlayerMoves; break;
                    case Enums.PlayerState.Up: Player.Y -= PlayerMoves; break;
                }
                return;
            }
            DebugConsole.WriteLine(Player.Position);
            // otherwise get the key press
            var keys = keyboardState.GetPressedKeys();
            if (keys.Length > 0)
            {
                switch (keys[0])
                {
                    case Keys.Left or Keys.A:
                        if (Player.State == Enums.PlayerState.Left && CurrentMap.IsTilePassable(Player.Position.X - 1, Player.Position.Y)) { Player.X -= PlayerMoves; Player.RunningState++; break; }
                        Player.State = Enums.PlayerState.Left; Player.RunningState = 0; break;
                    case Keys.Right or Keys.D:
                        if (Player.State == Enums.PlayerState.Right && CurrentMap.IsTilePassable(Player.Position.X + 1, Player.Position.Y)) { Player.X += PlayerMoves; Player.RunningState++; break; }
                        Player.State = Enums.PlayerState.Right; Player.RunningState = 0; break;
                    case Keys.Down or Keys.S:
                        if (Player.State == Enums.PlayerState.Down && CurrentMap.IsTilePassable(Player.Position.X, Player.Position.Y + 1)) { Player.Y += PlayerMoves; Player.RunningState++; break; }
                        Player.State = Enums.PlayerState.Down; Player.RunningState = 0; break;
                    case Keys.Up or Keys.W:
                        if (Player.State == Enums.PlayerState.Up && CurrentMap.IsTilePassable(Player.Position.X, Player.Position.Y - 1)) { Player.Y -= PlayerMoves; Player.RunningState++; break; }
                        Player.State = Enums.PlayerState.Up; Player.RunningState = 0; break;
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
            CurrentMap.Draw(Width, Height, Player, spriteBatch);
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
