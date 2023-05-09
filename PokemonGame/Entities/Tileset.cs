using Microsoft.Xna.Framework.Graphics;
using PokemonGame.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities;

public class Tileset
{
    private readonly List<TilePassability> _tileData;

    public Tileset()
    {
        _tileData = new List<TilePassability>();
    }

    public bool GetMovementPermission(int tileId)
    {
        return _tileData[tileId] == TilePassability.Passable;
    }

    private static TilePassability GetTilePassabilityFromId(int id)
    {
        return id switch
        {
            0 => TilePassability.Passable,
            1 => TilePassability.Impassable,
            _ => throw new ArgumentException(null, nameof(id))
        };
    }

    public static Tileset LoadFromData(string[] data)
    {
        Tileset t = new();
        foreach (var s in data)
        {
            t._tileData.Add(GetTilePassabilityFromId(int.Parse(s)));
        }

        return t;
    }
}