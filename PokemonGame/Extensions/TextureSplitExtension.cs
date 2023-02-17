using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PokemonGame.Extensions
{
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
            int xPieces = source.Width / pieceSize;
            int yPieces = source.Height / pieceSize;
            Texture2D[,] pieces = new Texture2D[xPieces, yPieces];
            Color[] pixels = new Color[pieceSize * pieceSize];
            for (int x = 0; x < xPieces; x++)
            {
                for (int y = 0; y < yPieces; y++)
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
}
