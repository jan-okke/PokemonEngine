using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Moltres : Pokemon
	{
		public override string Name => "Moltres";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flamebody() };
		public override Stats BaseStats => new Stats(90, 100, 90, 90, 125, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Leer() },
			[5] = new List<Move>() { new Ember() },
			[10] = new List<Move>() { new Safeguard() },
			[15] = new List<Move>() { new Wingattack() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Ancientpower() },
			[30] = new List<Move>() { new Incinerate() },
			[35] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Roost() },
			[45] = new List<Move>() { new Heatwave() },
			[50] = new List<Move>() { new Sunnyday() },
			[55] = new List<Move>() { new Hurricane() },
			[60] = new List<Move>() { new Endure() },
			[65] = new List<Move>() { new Burnup() },
			[70] = new List<Move>() { new Skyattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Bravebird(), new Burningjealousy(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fly(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Mysticalfire(), new Overheat(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Sandstorm(), new Scorchingsands(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Uturn(), new Weatherball(), new Willowisp() };
		public override int Weight => 600;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}