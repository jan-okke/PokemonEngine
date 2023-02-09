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
            foreach (Keys k in keyboardState.GetPressedKeys())
            {
                switch (k)
                {
                    case Keys.Left:
                        Player.X--; Player.State = Enums.PlayerState.Left; break;
                    case Keys.Right:
                        Player.X++; Player.State = Enums.PlayerState.Right; break;
                    case Keys.Down:
                        Player.Y--; Player.State = Enums.PlayerState.Down; break;
                    case Keys.Up:
                        Player.Y++; Player.State = Enums.PlayerState.Up; break;
                }
            }
            DebugConsole.WriteLine(Player.Position);
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
