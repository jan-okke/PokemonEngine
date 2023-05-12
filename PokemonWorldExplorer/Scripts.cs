namespace WorldExplorer;

public static class Scripts
{
    public static void StarterChoice()
    {
        var gotStarter = false;
        while (!gotStarter)
        {
            Console.WriteLine("Choose your starter! Charmander, Squirtle, Bulbasaur");
            var starter = Console.ReadLine();

            switch (starter)
            {
                case "Charmander" or "Squirtle" or "Bulbasaur":
                    Player.Instance.AddPokemon(starter, 5);
                    gotStarter = true;
                    break;
            }
        }
    }
}