﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Static
{
    public class ContentCollection
    {
        public static Dictionary<string, Texture2D> Textures { get; } = new Dictionary<string, Texture2D>();
    }
}
