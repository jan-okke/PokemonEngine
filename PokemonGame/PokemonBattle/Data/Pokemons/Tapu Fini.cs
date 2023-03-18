using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tapufini : Pokemon
	{
		public override string Name => "Tapu Fini";
		public override List<Ability> AvailableAbilities => new() {new Mistysurge() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(70, 75, 115, 95, 130, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Disarmingvoice(), new Watergun() },
			[5] = new List<Move>() { new Withdraw() },
			[10] = new List<Move>() { new Mist(), new Haze() },
			[15] = new List<Move>() { new Aquaring() },
			[20] = new List<Move>() { new Waterpulse() },
			[25] = new List<Move>() { new Brine() },
			[30] = new List<Move>() { new Defog() },
			[35] = new List<Move>() { new Healpulse() },
			[40] = new List<Move>() { new Surf() },
			[45] = new List<Move>() { new Muddywater() },
			[50] = new List<Move>() { new Meanlook() },
			[55] = new List<Move>() { new Naturesmadness() },
			[60] = new List<Move>() { new Moonblast() },
			[65] = new List<Move>() { new Hydropump() },
			[70] = new List<Move>() { new Soak() },
			[75] = new List<Move>() { new Mistyterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Blizzard(), new Brine(), new Calmmind(), new Dazzlinggleam(), new Dive(), new Drainingkiss(), new Endure(), new Facade(), new Fling(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irondefense(), new Lightscreen(), new Magicroom(), new Mistyterrain(), new Muddywater(), new Playrough(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Scald(), new Shadowball(), new Sleeptalk(), new Smartstrike(), new Snore(), new Storedpower(), new Substitute(), new Surf(), new Taunt(), new Trick(), new Waterfall(), new Whirlpool(), new Wonderroom() };
		public override int Weight => 212;
		public override int ExpYield => 285;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}