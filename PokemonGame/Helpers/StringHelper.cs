namespace PokemonGame.Helpers;

public abstract class StringHelper
{
    public static string Get4DigitString(int number) => number >= 1000 ? number.ToString() :
        number >= 100 ? "0" + number :
        number >= 10 ? "00" + number : "000" + number;
}