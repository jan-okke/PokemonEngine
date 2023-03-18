using System.Runtime.Intrinsics.X86;
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
    struct BasicMove
    {
        public string InternalName;
        public string Name;
        public string Type;
        public string Category;
        public int Power;
        public int Accuracy;
        public int PowerPoints;
        public int EffectChance;
        public int Priority;
        public string Target;
        public string[] Flags;
        public string Description;
    }
    struct BasicAbility
    {
        public string InternalName;
        public string Name;
        public string Description;
    }
    public static class Program
    {
        private static void AddText(this FileStream stream, string text)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        private static object SetParams(string key, string value, ref BasicMove move)
            => key switch
            {
                "Name" => move.Name = value,
                "Type" => move.Type = value,
                "Category" => move.Category = value,
                "Power" => move.Power = int.Parse(value),
                "Accuracy" => move.Accuracy = int.Parse(value),
                "TotalPP" => move.PowerPoints = int.Parse(value),
                "Target" => move.Target = value,
                "Flags" => move.Flags = value.Split(','),
                "FunctionCode" => 0,
                "EffectChance" => move.EffectChance = int.Parse(value),
                "Priority" => move.Priority = int.Parse(value),
                "Description" => move.Description = value,

                _ => throw new ArgumentException(key)
            };
        private static object SetParams(string key, string value, ref BasicAbility ability)
            => key switch
            {
                "Name" => ability.Name = value,
                "Description" => ability.Description = value,
                "Flags" => 0,

                _ => throw new ArgumentException(key)
            };
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

            #region Pokemons
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
                    "using PokemonGame.PokemonBattle.Data.Moves;\n" +
                    "using PokemonGame.PokemonBattle.Entities;\n" +
                    "using PokemonGame.PokemonBattle.Enums;\n" +
                    "using System.Collections.Generic;\n" +
                    "\n" +
                    "namespace PokemonGame.PokemonBattle.Data.Pokemons\n" +
                    "{\n" +
                    $"\tpublic class {p.InternalName[0] + p.InternalName[1..].ToLower()} : Pokemon\n" +
                    "\t{\n" +
                    $"\t\tpublic override string Name => \"{p.Name}\";\n" +
                    "\t\tpublic override List<Ability> AvailableAbilities => new() {");
                for (int i = 0; i < p.Abilities.Length; i++)
                {
                    var upperAbility = p.Abilities[i];
                    var ability = upperAbility[0] + upperAbility[1..].ToLower();
                    stream.AddText($"new {ability}()" + (p.Abilities.Length - i > 1 ? ", " : ""));
                }
                stream.AddText(" };\n");
                if (p.HiddenAbilities != null)
                {
                    stream.AddText("\t\tpublic override List<Ability> AvailableHiddenAbilities => new() {");
                    for (int i = 0; i < p.HiddenAbilities.Length; i++)
                    {
                        var upperAbility = p.HiddenAbilities[i];
                        var ability = upperAbility[0] + upperAbility[1..].ToLower();
                        stream.AddText($"new {ability}()" + (p.HiddenAbilities.Length - i > 1 ? ", " : ""));
                    }
                    stream.AddText(" };\n");
                }
                stream.AddText("\t\tpublic override Stats BaseStats => new Stats(");
                var baseHP = p.BaseStats[0];
                var baseAttack = p.BaseStats[1];
                var baseDefense = p.BaseStats[2];
                var baseSpeed = p.BaseStats[3];
                var baseSpAtk = p.BaseStats[4];
                var baseSpDef = p.BaseStats[5];
                stream.AddText($"{baseHP}, {baseAttack}, {baseDefense}, {baseSpAtk}, {baseSpDef}, {baseSpeed}");
                
                stream.AddText(
                    $");\n\t\tpublic override ExperienceGroup ExperienceGroup => ExperienceGroup.{p.GrowthRate};\n" +
                    "\t\tpublic override List<PokemonType> Types => new() {");
                for (int i = 0; i < p.Types.Length; i++)
                {
                    var upperType = p.Types[i];
                    var type = upperType[0] + upperType[1..].ToLower();
                    stream.AddText($"PokemonType.{type}" + (p.Types.Length - i > 1 ? ", " : ""));
                }
                stream.AddText(" };\n" +
                    "\t\tpublic override Dictionary<int, List<Move>> LevelUpLearnSet => new()\n" +
                    "\t\t{\n");
                Dictionary<int, List<string>> data = new Dictionary<int, List<string>>();
                int lastNumber = 0; // should not be 0 because initialized anyway
                string lastValue;
                for (int i = 0; i < p.MoveInfo.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        lastNumber = int.Parse(p.MoveInfo[i]);
                        data.TryAdd(lastNumber, new List<string>());
                    }
                    else
                    {
                        lastValue = p.MoveInfo[i];
                        data[lastNumber].Add(lastValue);
                    }
                }
                foreach (int level in data.Keys)
                {
                    stream.AddText($"\t\t\t[{level}] = new List<Move>() " + "{ ");
                    for (int i = 0; i < data[level].Count; i++)
                    {
                        var upperMove = data[level][i];
                        var move = upperMove[0] + upperMove[1..].ToLower();
                        stream.AddText($"new {move}()" + (data[level].Count - i > 1 ? ", " : ""));
                    }

                    stream.AddText(" },\n");
                }
                stream.AddText("\t\t};\n");
                if (p.TutorMoves != null)
                {
                    stream.AddText("\t\tpublic override List<Move> TutorMoves => new List<Move>() { ");
                    for (int i = 0; i < p.TutorMoves.Length; i++)
                    {
                        var upperMove = p.TutorMoves[i];
                        var move = upperMove[0] + upperMove[1..].ToLower();
                        stream.AddText($"new {move}()" + (p.TutorMoves.Length - i > 1 ? ", " : ""));
                    }
                    stream.AddText(" };\n");
                }
                if (p.EggMoves != null)
                {
                    stream.AddText("\t\tpublic override List<Move> EggMoves => new List<Move>() { ");
                    for (int i = 0; i < p.EggMoves.Length; i++)
                    {
                        var upperMove = p.EggMoves[i];
                        var move = upperMove[0] + upperMove.Substring(1).ToLower();
                        stream.AddText($"new {move}()" + (p.EggMoves.Length - i > 1 ? ", " : ""));
                    }
                    stream.AddText(" };\n");
                }
                stream.AddText($"\t\tpublic override int Weight => {p.Weight};\n");
                stream.AddText($"\t\tpublic override int ExpYield => {p.BaseExp};\n");
                stream.AddText($"\t\tpublic override int CatchRate => {p.CatchRate};\n");
                Dictionary<string, int> evdata = new Dictionary<string, int>();
                lastValue = ""; // should never be empty.
                for (int i = 0; i < p.RewardEVs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        lastValue = p.RewardEVs[i];
                    }
                    else
                    {
                        lastNumber = int.Parse(p.RewardEVs[i]);
                        evdata.Add(lastValue, lastNumber);
                    }
                }

                stream.AddText("\t\tpublic override Dictionary<Stat, int> EVYield => new()\n\t\t{\n");
                stream.AddText($"\t\t\t[Stat.HP] = {(evdata.ContainsKey("HP") ? evdata["HP"] : 0)},\n");
                stream.AddText($"\t\t\t[Stat.Attack] = {(evdata.ContainsKey("ATTACK") ? evdata["ATTACK"] : 0)},\n");
                stream.AddText($"\t\t\t[Stat.Defense] = {(evdata.ContainsKey("DEFENSE") ? evdata["DEFENSE"] : 0)},\n");
                stream.AddText($"\t\t\t[Stat.SpecialAttack] = {(evdata.ContainsKey("SPECIAL_ATTACK") ? evdata["SPECIAL_ATTACK"] : 0)},\n");
                stream.AddText($"\t\t\t[Stat.SpecialDefense] = {(evdata.ContainsKey("SPECIAL_DEFENSE") ? evdata["SPECIAL_DEFENSE"] : 0)},\n");
                stream.AddText($"\t\t\t[Stat.Speed] = {(evdata.ContainsKey("SPEED") ? evdata["SPEED"] : 0)}\n");
                stream.AddText("\t\t};\n");
                
                stream.AddText("\t}\n}");

                stream.Close();
            }
            #endregion
            #region Moves
            var movetxt = pbsdir + "\\moves.txt";

            List<BasicMove> moves = new List<BasicMove>();

            BasicMove mov = new BasicMove();
            initialized = false;

            foreach (string line in File.ReadAllLines(movetxt))
            {
                if (line.StartsWith("#")) continue;
                if (line.StartsWith("["))
                {
                    string moveName = line[1..^1];
                    if (initialized)
                    {
                        moves.Add(mov);
                    }
                    mov = new();
                    mov.InternalName = moveName;
                    Console.WriteLine(moveName);
                    initialized = true;
                    continue;
                }
                string key, value;
                key = line.Split(" = ")[0];
                value = line.Split(" = ")[1];
                SetParams(key, value, ref mov);
            }

            // Data is in moves now

            targetdir = gamedir + "\\PokemonBattle\\Data\\Moves";

            foreach (BasicMove m in moves)
            {
                var path = targetdir + $"\\{m.Name}.cs";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using FileStream stream = File.Create(path);
                stream.AddText("" +
                    "using PokemonGame.PokemonBattle.Entities;\n" +
                    "using PokemonGame.PokemonBattle.Enums;\n" +
                    "using System.Collections.Generic;\n" +
                    "\n" +
                    "namespace PokemonGame.PokemonBattle.Data.Moves\n" +
                    "{\n" +
                    $"\tpublic class {m.InternalName[0] + m.InternalName[1..].ToLower()} : Move\n" +
                    "\t{\n" +
                    $"\t\tpublic override string Name => \"{m.Name}\";\n" +
                    $"\t\tpublic override string Description => \"{m.Description}\";\n" +
                    $"\t\tpublic override int BasePower => {m.Power};\n" +
                    $"\t\tpublic override int PowerPoints => {m.PowerPoints};\n" +
                    $"\t\tpublic override int Priority => {m.Priority};\n" +
                    $"\t\tpublic override MoveCategory Category => MoveCategory.{m.Category};\n" +
                    $"\t\tpublic override PokemonType Type => PokemonType.{m.Type[0] + m.Type[1..].ToLower()};\n");

                

                stream.AddText($"\t\tpublic {m.InternalName[0] + m.InternalName[1..].ToLower()}()\n" +
                    "\t\t{\n" +
                    "\t\t\tCurrentPowerPoints = PowerPoints;\n" +
                    "\t\t}\n");

                stream.AddText("\t}\n}");
                stream.Close();
            }
            #endregion

            var abilitiestxt = pbsdir + "\\abilities.txt";

            List<BasicAbility> abilities = new List<BasicAbility>();

            BasicAbility abil = new BasicAbility();
            initialized = false;

            foreach (string line in File.ReadAllLines(abilitiestxt))
            {
                if (line.StartsWith("#")) continue;
                if (line.StartsWith("["))
                {
                    string abilityName = line[1..^1];
                    if (initialized)
                    {
                        abilities.Add(abil);
                    }
                    abil = new();
                    abil.InternalName = abilityName;
                    Console.WriteLine(abilityName);
                    initialized = true;
                    continue;
                }
                string key, value;
                key = line.Split(" = ")[0];
                value = line.Split(" = ")[1];
                SetParams(key, value, ref abil);
            }

            // Data is in abilities now

            targetdir = gamedir + "\\PokemonBattle\\Data\\Abilities";

            foreach (BasicAbility a in abilities)
            {
                var path = targetdir + $"\\{a.Name}.cs";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using FileStream stream = File.Create(path);
                stream.AddText("" +
                    "using PokemonGame.PokemonBattle.Entities;\n" +
                    "using PokemonGame.PokemonBattle.Enums;\n" +
                    "using System.Collections.Generic;\n" +
                    "\n" +
                    "namespace PokemonGame.PokemonBattle.Data.Abilities\n" +
                    "{\n" +
                    $"\tpublic class {a.InternalName[0] + a.InternalName[1..].ToLower()} : Ability\n" +
                    "\t{\n" +
                    $"\t\tpublic override string Name => \"{a.Name}\";\n" +
                    $"\t\tpublic override string Description => \"{a.Description.Replace("\"", "'")}\";\n" +
                    "\t}\n}");

                stream.Close();
            }
        }
    }
}