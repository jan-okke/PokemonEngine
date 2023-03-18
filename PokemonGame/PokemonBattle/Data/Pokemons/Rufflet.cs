using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rufflet : Pokemon
	{
		public override string Name => "Rufflet";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(70, 83, 50, 60, 37, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Leer() },
			[6] = new List<Move>() { new Honeclaws() },
			[12] = new List<Move>() { new Wingattack() },
			[18] = new List<Move>() { new Tailwind() },
			[24] = new List<Move>() { new Scaryface() },
			[30] = new List<Move>() { new Aerialace() },
			[36] = new List<Move>() { new Slash() },
			[42] = new List<Move>() { new Whirlwind() },
			[48] = new List<Move>() { new Crushclaw() },
			[55] = new List<Move>() { new Airslash() },
			[60] = new List<Move>() { new Defog() },
			[66] = new List<Move>() { new Thrash() },
			[72] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Assurance(), new Attract(), new Bravebird(), new Bulkup(), new Closecombat(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Uturn(), new Workup(), new Zenheadbutt() };
		public override int Weight => 105;
		public override int ExpYield => 70;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}