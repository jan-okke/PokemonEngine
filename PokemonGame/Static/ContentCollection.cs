using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PokemonGame.Entities;

namespace PokemonGame.Static;

public class ContentCollection
{
    public static Dictionary<string, Texture2D> Textures { get; } = new();
    public static Dictionary<string, TextureAtlas> Splits { get; } = new();
}