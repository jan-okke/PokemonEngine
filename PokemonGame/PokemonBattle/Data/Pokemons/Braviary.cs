using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Braviary : Pokemon
	{
		public override string Name => "Braviary";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(100, 123, 75, 80, 57, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Superpower() },
			[1] = new List<Move>() { new Superpower(), new Skyattack(), new Peck(), new Leer(), new Honeclaws(), new Wingattack() },
			[18] = new List<Move>() { new Tailwind() },
			[24] = new List<Move>() { new Scaryface() },
			[30] = new List<Move>() { new Aerialace() },
			[36] = new List<Move>() { new Slash() },
			[42] = new List<Move>() { new Whirlwind() },
			[48] = new List<Move>() { new Crushclaw() },
			[57] = new List<Move>() { new Airslash() },
			[64] = new List<Move>() { new Defog() },
			[72] = new List<Move>() { new Thrash() },
			[80] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Assurance(), new Attract(), new Bravebird(), new Bulkup(), new Closecombat(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Ironhead(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Uturn(), new Workup(), new Zenheadbutt() };
		public override int Weight => 410;
		public override int ExpYield => 179;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}