using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Joltik : Pokemon
	{
		public override string Name => "Joltik";
		public override List<Ability> AvailableAbilities => new() {new Compoundeyes(), new Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swarm() };
		public override Stats BaseStats => new Stats(50, 47, 50, 65, 57, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Furycutter() },
			[4] = new List<Move>() { new Electroweb() },
			[8] = new List<Move>() { new Bugbite() },
			[12] = new List<Move>() { new Stringshot() },
			[16] = new List<Move>() { new Thunderwave() },
			[20] = new List<Move>() { new Electroball() },
			[24] = new List<Move>() { new Agility() },
			[28] = new List<Move>() { new Suckerpunch() },
			[32] = new List<Move>() { new Slash() },
			[37] = new List<Move>() { new Discharge() },
			[40] = new List<Move>() { new Screech() },
			[44] = new List<Move>() { new Gastroacid() },
			[48] = new List<Move>() { new Bugbuzz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bounce(), new Bugbuzz(), new Crosspoison(), new Electroball(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Hiddenpower(), new Leechlife(), new Lightscreen(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Speedswap(), new Substitute(), new Swift(), new Thief(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Wildcharge(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Doubleteam(), new Infestation(), new Lunge(), new Poisonsting(), new Strugglebug() };
		public override int Weight => 6;
		public override int ExpYield => 64;
		public override int CatchRate => 190;
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