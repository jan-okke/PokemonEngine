using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PokemonGame.Extensions;

public static class TextureSplitExtension
{
    /// <summary>
    /// ChatGPT implemented.
    /// </summary>
    /// <param name="source"></param>
    /// <param name="pieceSize"></param>
    /// <returns></returns>
    public static Texture2D[,] Split(Texture2D source, int pieceSize)
    {
        var xPieces = source.Width / pieceSize;
        var yPieces = source.Height / pieceSize;
        var pieces = new Texture2D[xPieces, yPieces];
        var pixels = new Color[pieceSize * pieceSize];
        for (var x = 0; x < xPieces; x++)
        {
            for (var y = 0; y < yPieces; y++)
            {
                SetPieceData(pieces, x, y, source, pieceSize, pixels);
            }
        }
        return pieces;
    }
    private static void SetPieceData(Texture2D[,] pieces, int x, int y, Texture2D source, int pieceSize, Color[] pixels)
    {
        pieces[x, y] = new Texture2D(source.GraphicsDevice, pieceSize, pieceSize);
        source.GetData(0, new Rectangle(x * pieceSize, y * pieceSize, pieceSize, pieceSize), pixels, 0, pieceSize * pieceSize);
        pieces[x, y].SetData(pixels);
    }
}