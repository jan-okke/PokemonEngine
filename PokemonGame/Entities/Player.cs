using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PokemonGame.Enums;

using PokemonGame.PokemonBattle.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class Player
    {
        public List<Pokemon> PokemonBox { get; } = new List<Pokemon>();

        public int X { get; set; }
        public int Y { get; set; }
        public Point Position 
        { 
            get => new Point((X - 64 + Settings.DisplayWidth / 2) / 32, (Y - 48 + Settings.DisplayHeight / 2) / 32);
            set { X = 64 + value.X * 32 - Settings.DisplayWidth / 2; Y = 48 + value.Y * 32 - Settings.DisplayHeight / 2; }
        }

        public TextureAtlas TextureAtlas { get; set; }
        public PlayerState State { get; set; }
        private int _runningState;

        public bool InAnimation => X % 32 != 0 || Y % 32 != 0;
        public int RunningState 
        {
            get => _runningState;
            set { _runningState = value > 3 ? 0 : value; } // cycle between 0-1-2-3-0...
        }

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
