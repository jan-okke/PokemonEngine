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
        public PokemonGame() 
        {
            
        }
        public void SetMap(Map map)
        {
            CurrentMap = map;
        }
        public void Update(KeyboardState keyboardState)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            CurrentMap.Draw(Player, spriteBatch);
        }

        public void SetDefaultMap()
        {
            SetMap(Map.LoadFromFile("GameFiles\\Data\\Maps\\Map" + Helpers.StringHelper.Get4DigitString(Settings.StartMapID) + ".txt"));
        }
    }
}
