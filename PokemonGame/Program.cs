
using System;

using var game = new PokemonGame.Game1();
try 
{
    game.Run();
}
catch (Exception e)
{
    Console.WriteLine(e);
    Console.ReadLine();
}