using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vullaby : Pokemon
	{
		public override string Name => "Vullaby";
		public override List<Ability> AvailableAbilities => new() {new Bigpecks(), new Overcoat() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(70, 55, 75, 45, 65, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Leer() },
			[6] = new List<Move>() { new Flatter() },
			[12] = new List<Move>() { new Pluck() },
			[18] = new List<Move>() { new Tailwind() },
			[24] = new List<Move>() { new Knockoff() },
			[30] = new List<Move>() { new Irondefense() },
			[36] = new List<Move>() { new Whirlwind() },
			[42] = new List<Move>() { new Airslash() },
			[48] = new List<Move>() { new Darkpulse() },
			[54] = new List<Move>() { new Nastyplot() },
			[60] = new List<Move>() { new Defog() },
			[66] = new List<Move>() { new Attract() },
			[72] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Assurance(), new Attract(), new Bravebird(), new Darkpulse(), new Dualwingbeat(), new Endure(), new Facade(), new Faketears(), new Fly(), new Foulplay(), new Heatwave(), new Hiddenpower(), new Irondefense(), new Lashout(), new Nastyplot(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rocktomb(), new Round(), new Scaryface(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thief(), new Uturn() };
		public override List<Move> EggMoves => new List<Move>() { new Meanlook(), new Roost(), new Toxic() };
		public override int Weight => 90;
		public override int ExpYield => 74;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}