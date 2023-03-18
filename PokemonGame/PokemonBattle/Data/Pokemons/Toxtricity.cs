using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Toxtricity : Pokemon
	{
		public override string Name => "Toxtricity";
		public override List<Ability> AvailableAbilities => new() {new Punkrock(), new Plus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(75, 98, 70, 75, 114, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Spark() },
			[1] = new List<Move>() { new Spark(), new Eerieimpulse(), new Belch(), new Tearfullook(), new Nuzzle(), new Growl(), new Flail(), new Acid(), new Thundershock(), new Acidspray(), new Leer(), new Nobleroar() },
			[4] = new List<Move>() { new Charge() },
			[8] = new List<Move>() { new Shockwave() },
			[12] = new List<Move>() { new Scaryface() },
			[16] = new List<Move>() { new Taunt() },
			[20] = new List<Move>() { new Venoshock() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Swagger() },
			[32] = new List<Move>() { new Toxic() },
			[36] = new List<Move>() { new Discharge() },
			[40] = new List<Move>() { new Poisonjab() },
			[44] = new List<Move>() { new Overdrive() },
			[48] = new List<Move>() { new Boomburst() },
			[52] = new List<Move>() { new Shiftgear() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Drainpunch(), new Eerieimpulse(), new Electroball(), new Encore(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Gigaimpact(), new Gunkshot(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Risingvoltage(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snarl(), new Snore(), new Storedpower(), new Substitute(), new Swift(), new Taunt(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Venoshock(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 400;
		public override int ExpYield => 176;
		public override int CatchRate => 45;
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