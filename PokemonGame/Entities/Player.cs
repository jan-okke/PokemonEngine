using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PokemonGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point Position => new Point(X, Y);

        public TextureAtlas TextureAtlas { get; set; }
        public PlayerState State { get; set; }
        public int RunningState { get; set; }

        public Player(Texture2D texture, int splitSize)
        {
            X = 0;
            Y = 0;
            State = PlayerState.Down;
            RunningState = 0;
            TextureAtlas = new TextureAtlas(texture, splitSize);
        }
        public Texture2D GetCurrentTexture()
        {
            // Column oben nach unten
            // Row links nach rechts
            int column = (int)State;
            int row = RunningState;
            return TextureAtlas.GetTextureAt(row, column);
        }
    }
}
