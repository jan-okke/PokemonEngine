using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Galvantula : Pokemon
	{
		public override string Name => "Galvantula";
		public override List<Ability> AvailableAbilities => new() {new Compoundeyes(), new Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swarm() };
		public override Stats BaseStats => new Stats(70, 77, 60, 97, 60, 108);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Stickyweb() },
			[1] = new List<Move>() { new Stickyweb(), new Absorb(), new Furycutter(), new Electroweb(), new Bugbite() },
			[12] = new List<Move>() { new Stringshot() },
			[16] = new List<Move>() { new Thunderwave() },
			[20] = new List<Move>() { new Electroball() },
			[24] = new List<Move>() { new Agility() },
			[28] = new List<Move>() { new Suckerpunch() },
			[32] = new List<Move>() { new Slash() },
			[39] = new List<Move>() { new Discharge() },
			[44] = new List<Move>() { new Screech() },
			[50] = new List<Move>() { new Gastroacid() },
			[56] = new List<Move>() { new Bugbuzz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bounce(), new Bugbuzz(), new Crosspoison(), new Electroball(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Leechlife(), new Lightscreen(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Speedswap(), new Substitute(), new Swift(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Wildcharge(), new Xscissor() };
		public override int Weight => 143;
		public override int ExpYield => 165;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}