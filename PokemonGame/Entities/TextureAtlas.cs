using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class TextureAtlas
    {
        private Texture2D Graphic;
        private Texture2[,] Textures;

        private void ConvertTextureToAtlas(int splitSize)
        {
            Textures = null; // TODO
        }

        public TextureAtlas(Texture2D graphic, int splitSize) 
        {
            Graphic = graphic;
            ConvertTextureToAtlas(splitSize);
        }
	public Texture2D[,] GetTextures()
        {
            return Textures;
        }
	public Texture2D GetTextureAt(int x, int y)
        {
            return Textures[x, y];
        }
    }
}
