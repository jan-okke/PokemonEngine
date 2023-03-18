using System.Text;

namespace PBSMaker
{
    struct BasicPokemon
    {
        public string InternalName;
        public string Name;
        public string[] Types;
        public string[] BaseStats;
        public string GrowthRate;
        public int BaseExp;
        public string[] RewardEVs;
        public int CatchRate;
        public int Happiness;
        public string[] Abilities;
        public string[] HiddenAbilities;
        public string[] MoveInfo;
        public string[] TutorMoves;
        public string[] EggMoves;
        public string[] EggGroups;
        public int HatchSteps;
        public double Height;
        public double Weight;
        public string Pokedex;
        public int Generation;
        public string[] EvolutionInfo;
    }
    public static class Program
    {
        private static void AddText(this FileStream stream, string text)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        private static object SetParams(string key, string value, ref BasicPokemon poke)
            => key switch
            {
                "Name" => poke.Name = value,
                "Types" => poke.Types = value.Split(','),
                "BaseStats" => poke.BaseStats = value.Split(','),
                "GenderRatio" => 0,
                "GrowthRate" => poke.GrowthRate = value,
                "BaseExp" => poke.BaseExp = int.Parse(value),
                "EVs" => poke.RewardEVs = value.Split(','),
                "CatchRate" => poke.CatchRate = int.Parse(value),
                "Happiness" => poke.Happiness = int.Parse(value),
                "Abilities" => poke.Abilities = value.Split(','),
                "HiddenAbilities" => poke.HiddenAbilities = value.Split(','),
                "Moves" => poke.MoveInfo = value.Split(','),
                "TutorMoves" => poke.TutorMoves = value.Split(','),
                "EggMoves" => poke.EggMoves = value.Split(','),
                "EggGroups" => poke.EggGroups = value.Split(','),
                "HatchSteps" => poke.HatchSteps = int.Parse(value),
                "Height" => poke.Height = double.Parse(value),
                "Weight" => poke.Weight = double.Parse(value),
                "Color" => 0,
                "Shape" => 0,
                "Habitat" => 0,
                "Category" => 0,
                "Pokedex" => poke.Pokedex = value,
                "Generation" => poke.Generation = int.Parse(value),
                "Evolutions" => poke.EvolutionInfo = value.Split(','),

                "WildItemUncommon" => 0,
                "WildItemCommon" => 0,
                "WildItemRare" => 0,
                "Offspring" => 0,
                "FormName" => 0,
                "Incense" => 0,
                "Flags" => 0,
                _ => throw new ArgumentException(key)
            };
        public static void Main(string[] args)
        {
            var net6dir = Environment.CurrentDirectory;
            var debugdir = Directory.GetParent(net6dir);
            var bindir = debugdir.Parent;
            var projdir = bindir.Parent;
            var enginedir = projdir.Parent;
            var gamedir = enginedir.FullName + "\\PokemonGame";
            var gamebin = gamedir + "\\bin\\Debug\\net6.0";
            var pbsdir = gamebin + "\\GameFiles\\PBS";

            var pokemontxt = pbsdir + "\\pokemon.txt";

            List<BasicPokemon> pokemons = new List<BasicPokemon>();

            BasicPokemon poke = new();
            bool initialized = false;

            foreach (string line in File.ReadLines(pokemontxt)) 
            {
                if (line.StartsWith("#")) continue;
                if (line.StartsWith("["))
                {
                    string pokemonName = line[1..^1];
                    if (initialized)
                    {
                        pokemons.Add(poke);
                    }
                    poke = new();
                    poke.InternalName = pokemonName;
                    Console.WriteLine(pokemonName);
                    initialized = true;
                    continue;
                }
                string key, value;
                key = line.Split(" = ")[0];
                value= line.Split(" = ")[1];
                SetParams(key, value, ref poke);
            }

            // Data is in pokemons now

            var targetdir = gamedir + "\\PokemonBattle\\Data\\Pokemons";

            foreach (BasicPokemon p in pokemons)
            {
                var path = targetdir + $"\\{p.Name}.cs";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using FileStream stream = File.Create(path);
                stream.AddText("" +
                    "using PokemonGame.PokemonBattle.Data.Abilities;\n" +
                    "using PokemonGame.PokemonBattle.Entities;\n" +
                    "using PokemonGame.PokemonBattle.Enums;\n" +
                    "using System.Collections.Generic;\n" +
                    "\n" +
                    "namespace PokemonGame.PokemonBattle.Data.Pokemons\n" +
                    "{\n" +
                    $"\tpublic class {p.Name} : Pokemon\n" +
                    "\t{\n" +
                    $"\t\tpublic override string Name => \"{p.Name}\";\n" +
                    "\t\tpublic override List<Ability> AvailableAbilities => new() {");
                for (int i = 0; i < p.Abilities.Length; i++)
                {
                    var upperAbility = p.Abilities[i];
                    var ability = upperAbility[0] + upperAbility.Substring(1).ToLower();
                    stream.AddText($"new {ability}()" + (p.Abilities.Length - i > 1 ? ", " : ""));
                }
                stream.AddText(" };\n");
                if (p.HiddenAbilities != null)
                {
                    stream.AddText("\t\tpublic override List<Ability> AvailableHiddenAbilities => new() {");
                    for (int i = 0; i < p.HiddenAbilities.Length; i++)
                    {
                        var upperAbility = p.HiddenAbilities[i];
                        var ability = upperAbility[0] + upperAbility.Substring(1).ToLower();
                        stream.AddText($"new {ability}()" + (p.HiddenAbilities.Length - i > 1 ? ", " : ""));
                    }
                    stream.AddText(" };\n");
                }
                stream.AddText("\t\tpublic override Stats BaseStats => new Stats(");
                for (int i = 0; i < p.BaseStats.Length; i++)
                {
                    var value = int.Parse(p.BaseStats[i]);
                    stream.AddText($"{value}" + (p.BaseStats.Length - i > 1 ? ", " : ""));
                }
                stream.AddText(
                    $");\n\t\tpublic override ExperienceGroup ExperienceGroup => ExperienceGroup.{p.GrowthRate};\n" +
                    "\t\tpublic override List<PokemonType> Types => new() {");
                for (int i = 0; i < p.Types.Length; i++)
                {
                    var upperType = p.Types[i];
                    var type = upperType[0] + upperType.Substring(1).ToLower();
                    stream.AddText($"PokemonType.{type}" + (p.Types.Length - i > 1 ? ", " : ""));
                }
                stream.AddText(" };\n");

                stream.Close();
            }
        }
    }
}