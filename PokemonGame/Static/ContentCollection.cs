using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using PokemonGame.Entities;

namespace PokemonGame.Static;

public class ContentCollection
{
    public static Dictionary<string, Texture2D> Textures { get; } = new();
    public static Dictionary<string, TextureAtlas> Splits { get; } = new();
}