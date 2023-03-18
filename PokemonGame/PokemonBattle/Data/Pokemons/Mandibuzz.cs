using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mandibuzz : Pokemon
	{
		public override string Name => "Mandibuzz";
		public override List<Ability> AvailableAbilities => new() {new Bigpecks(), new Overcoat() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(110, 65, 105, 80, 55, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Bonerush() },
			[1] = new List<Move>() { new Bonerush(), new Skyattack(), new Toxic(), new Gust(), new Leer(), new Flatter(), new Pluck() },
			[18] = new List<Move>() { new Tailwind() },
			[24] = new List<Move>() { new Knockoff() },
			[30] = new List<Move>() { new Irondefense() },
			[36] = new List<Move>() { new Whirlwind() },
			[42] = new List<Move>() { new Airslash() },
			[48] = new List<Move>() { new Darkpulse() },
			[57] = new List<Move>() { new Nastyplot() },
			[64] = new List<Move>() { new Defog() },
			[72] = new List<Move>() { new Attract() },
			[80] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Assurance(), new Attract(), new Bravebird(), new Darkpulse(), new Dualwingbeat(), new Endure(), new Facade(), new Faketears(), new Fly(), new Foulplay(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Lashout(), new Nastyplot(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rocktomb(), new Round(), new Scaryface(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thief(), new Uturn() };
		public override int Weight => 395;
		public override int ExpYield => 179;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}