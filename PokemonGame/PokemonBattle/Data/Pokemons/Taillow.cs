using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Taillow : Pokemon
	{
		public override string Name => "Taillow";
		public override List<Ability> AvailableAbilities => new() {new Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Scrappy() };
		public override Stats BaseStats => new Stats(40, 55, 30, 30, 30, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Growl() },
			[5] = new List<Move>() { new Focusenergy() },
			[9] = new List<Move>() { new Quickattack() },
			[13] = new List<Move>() { new Wingattack() },
			[17] = new List<Move>() { new Doubleteam() },
			[21] = new List<Move>() { new Aerialace() },
			[25] = new List<Move>() { new Quickguard() },
			[29] = new List<Move>() { new Agility() },
			[33] = new List<Move>() { new Airslash() },
			[37] = new List<Move>() { new Endeavor() },
			[41] = new List<Move>() { new Bravebird() },
			[45] = new List<Move>() { new Reversal() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Fly(), new Frustration(), new Heatwave(), new Hiddenpower(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Skyattack(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Boomburst(), new Bravebird(), new Hurricane(), new Skyattack(), new Supersonic(), new Whirlwind() };
		public override int Weight => 23;
		public override int ExpYield => 54;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}