using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonGame.Extensions;

namespace PokemonGame.Entities;

public class TextureAtlas
{
    private readonly Texture2D _graphic;
    private Texture2D[,] _textures;

    private void ConvertTextureToAtlas(int splitSize)
    {
        _textures = TextureSplitExtension.Split(_graphic, splitSize);
    }

    public TextureAtlas(Texture2D graphic, int splitSize)
    {
        _graphic = graphic;
        ConvertTextureToAtlas(splitSize);
    }

    public Texture2D[,] GetTextures()
    {
        return _textures;
    }

    public Texture2D GetTextureAt(int x, int y)
    {
        return _textures[x, y];
    }
}