using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PokemonGame.Entities;
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
            DebugConsole.WriteLine(Player.InAnimation);
            DebugConsole.WriteLine(Player.Position);
            if (Player.InAnimation)
            {
                switch (Player.State)
                {
                    case Enums.PlayerState.Left: Player.X -= PlayerMoves; break;
                    case Enums.PlayerState.Right: Player.X += PlayerMoves; break;
                    case Enums.PlayerState.Down: Player.Y -= PlayerMoves; break;
                    case Enums.PlayerState.Up: Player.Y += PlayerMoves; break;
                }
                return;
            }
            var keys = keyboardState.GetPressedKeys();
            if (keys.Length > 0)
            {
                switch (keys[0])
                {
                    case Keys.Left:
                        if (Player.State == Enums.PlayerState.Left) { Player.X -= PlayerMoves; Player.RunningState++; break; }
                        Player.State = Enums.PlayerState.Left; Player.RunningState = 0; break;
                    case Keys.Right:
                        if (Player.State == Enums.PlayerState.Right) { Player.X += PlayerMoves; Player.RunningState++; break; }
                        Player.State = Enums.PlayerState.Right; Player.RunningState = 0; break;
                    case Keys.Down:
                        if (Player.State == Enums.PlayerState.Down) { Player.Y -= PlayerMoves; Player.RunningState++; break; }
                        Player.State = Enums.PlayerState.Down; Player.RunningState = 0; break;
                    case Keys.Up:
                        if (Player.State == Enums.PlayerState.Up) { Player.Y += PlayerMoves; Player.RunningState++; break; }
                        Player.State = Enums.PlayerState.Up; Player.RunningState = 0; break;
                }
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
    }
}
